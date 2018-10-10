using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;
using Xamarin.Forms;
using UBNT.Models;
using UBNT.Views;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http.Headers;

namespace UBNT.ViewController
{
    
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _happened;
        private INavigation Navigation;
        public Command MainPageCommand { get; set; }
        public bool HasPropertyValueChanged {
            get => _happened;
            set
            {
                _happened = value;
                OnPropertyChanged();
            }
        }
        private InfoUsuario _data;
        public InfoUsuario userData {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }
        public Command LoginCommand { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoginCommand = new Command(async () => await NavigateToMainPage());
            MainPageCommand = new Command(async () => await NavigateToMainPage());
        }

        public async Task NavigateToMainPage()
        {
            HasPropertyValueChanged = true;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://portal.icentral.com.mx/api/v1.0/clients");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.TryAddWithoutValidation("X-Auth-App-Key", "RxLodODMKZJjrYt9GLeP01tf9QVZsfh3mN9EE5qd9l5jstpN0hbNnPqLdhqTYamB");
                    using (var response =
                        await client.GetAsync(client.BaseAddress))
                    {
                        try
                        {
                            response.EnsureSuccessStatusCode();
                            var jsonResult = await response.Content.ReadAsStringAsync();
                            ////////////
                            var root = JToken.Parse(jsonResult);
                            var values = root.Where(t => (string)t["username"] == email).ToList();
                            var mensage = string.Join(Environment.NewLine, values);
                            var result = JsonConvert.DeserializeObject<InfoUsuario>(mensage);
                            userData = result;
                            if (userData.contacts.ElementAt(0).phone.ToString() == phone)
                            {
                                HasPropertyValueChanged = false;
                                await Navigation.PushAsync(new Principal());
                            }
                            else
                            {
                                HasPropertyValueChanged = false;
                                await Application.Current.MainPage.DisplayAlert("Oops", "Check your Credentials", "OK");
                            }
                        }
                        catch (HttpRequestException e)
                        {
                            if (e.Message.Contains("Failed to connect to") == true)
                            {
                                await Application.Current.MainPage.DisplayAlert("Oops", e.Message, "OK");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HasPropertyValueChanged = false;
                await Application.Current.MainPage.DisplayAlert("Offline", "Service Currently Unavailable", "OK");               
            }
            ////////////
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
