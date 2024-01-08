using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1_SAEG.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1_SAEG
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaDeFormas : ContentPage
	{
		public PaginaDeFormas ()
		{
			InitializeComponent ();
			BindingContext = new VMPaginaDeFormas(Navigation);
		}
	}
}