//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPPresentLevelView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IEPPresentLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IEPPresentLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IIEPPresentLevel View Model as the data context for the view
        /// </summary>
        public IEPPresentLevelView(Interfaces.IIEPPresentLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
