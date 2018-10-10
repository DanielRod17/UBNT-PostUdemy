using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBNT.Models;
using UBNT.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UBNT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal (InfoUsuario usuario = null)
		{
			InitializeComponent();
            //BindingContext = new PrincipalViewViewModel(Navigation, user);
        }
	}
}