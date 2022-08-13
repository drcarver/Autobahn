//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IEPPresentLevelView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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
