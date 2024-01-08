using Practica1_SAEG.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1_SAEG.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EtiquetasParaEstablecerValores : ContentPage
	{
		public EtiquetasParaEstablecerValores()
		{
			InitializeComponent ();
			BindingContext = new VMEtiquetasParaEstablecerValores(Navigation);

        }
	}
}