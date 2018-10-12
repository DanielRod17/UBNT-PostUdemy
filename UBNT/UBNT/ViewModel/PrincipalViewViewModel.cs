using System;
using System.Collections.Generic;
using System.Text;
using UBNT.Models;
using Xamarin.Forms;

namespace UBNT.ViewModel
{
    class PrincipalViewViewModel
    {

        public InfoUsuario User { get; set; }
        public string nombreCompleto { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public string status { get; set; }
        public string subscripcion { get; set; }
        public string activo { get; set; }
        public string dayPago { get; set; }

        public string balance { get; set; }
        public UsuarioServicios Servicios { get; set; }
        public INavigation Navigation;

        public PrincipalViewViewModel(INavigation navigation, InfoUsuario usuario, UsuarioServicios servicios)
        {
            int index = 0;
            User = usuario;
            Servicios = servicios;
            Navigation = navigation;
            nombreCompleto = User.firstName + " " + User.lastName;
            direccion = User.street1;
            telefono = "Tel. "+ User.contacts[0].phone;

            if (Servicios.status == 1)
            {
                status = "Estado: Activo";
            }
            else
            {
                status = "Estado: Inactivo";
            }
            if (Servicios.invoicingStart.ToString().Length == 24)
            {
                index = 10;
            }
            else
            {
                index = 9;
            }
            subscripcion = "Subscripción: " + Servicios.name;
            activo = "Activo desde: " + Servicios.invoicingStart.ToString().Substring(0, index);
            dayPago = "Día de Pago: " + Servicios.invoicingPeriodStartDay + " de cada mes";
            balance = "$" + User.accountOutstanding + " " + User.currencyCode;
        }
    }
}
