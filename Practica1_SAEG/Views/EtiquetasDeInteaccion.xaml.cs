using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Practica1_SAEG.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1_SAEG.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EtiquetasDeInteaccion : ContentPage
	{
		public EtiquetasDeInteaccion ()
		{
			InitializeComponent ();
			BindingContext = new VMEtiquetasDeInteaccion(Navigation); 
		}
	}
}