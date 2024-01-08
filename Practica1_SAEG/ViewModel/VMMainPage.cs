using Practica1_SAEG.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1_SAEG.ViewModel
{
    public class VMMainPage : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMMainPage(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task VistaDeFormas()
        {
            await Navigation.PushAsync(new PaginaDeFormas());
        }
        public async Task VistaEtiquetasDeInteaccion()
        {
            await Navigation.PushAsync(new EtiquetasDeInteaccion());
        }
        #endregion
        #region CO
        public ICommand CambioDeVentanaCommand => new Command(async () => await VistaDeFormas());
        public ICommand IrAVistaEtiquetasDeInteaccionCommand => new Command(async () => await VistaEtiquetasDeInteaccion());
        #endregion
    }
}
