//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderView.cs
//**********************************************************

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeProviderView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeProviderView : ContentPage
    {
        /// <summary>
        /// Inject the IAeProvider View Model as the data context for the view
        /// </summary>
        public AeProviderView(Interfaces.IAeProvider vm)
        {
            BindingContext  = vm;
        }
    }
}
