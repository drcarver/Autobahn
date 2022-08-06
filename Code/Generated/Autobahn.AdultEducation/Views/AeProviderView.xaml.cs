//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeProviderView.cs
//**********************************************************

using Autobahn.AdultEducation.ViewModels;

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeProviderView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeProviderView : ContentPage
    {
        /// <summary>
        /// Inject the AeProviderViewModel as the data context for the view
        /// </summary>
        public AeProviderView(AeProviderViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
