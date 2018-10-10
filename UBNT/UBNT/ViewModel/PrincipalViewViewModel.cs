using System;
using System.Collections.Generic;
using System.Text;
using UBNT.Models;
using Xamarin.Forms;

namespace UBNT.ViewModel
{
    class PrincipalViewViewModel
    {

        public InfoUsuario NewFriend { get; set; }
        public INavigation Navigation;

        public PrincipalViewViewModel(INavigation navigation, InfoUsuario usuario)
        {
            NewFriend = usuario;
            Navigation = navigation;
        }
    }
}
