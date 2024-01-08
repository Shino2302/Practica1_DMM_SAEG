using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1_SAEG.ViewModel
{
    class VMEtiquetasParaEstablecerValores : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMEtiquetasParaEstablecerValores(INavigation navigation)
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
        public async Task RegresarAPaginaAnterior()
        {
            await Navigation.PopAsync();
        }
        #endregion
        #region CO
        public ICommand RegresarAPaginaAnteriorCommand => new Command(async () => await RegresarAPaginaAnterior());
        #endregion
    }
}
