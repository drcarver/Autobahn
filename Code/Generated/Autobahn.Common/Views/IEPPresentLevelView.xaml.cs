//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPPresentLevelView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IEPPresentLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IEPPresentLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IIEPPresentLevelViewModel as the data context for the view
        /// </summary>
        public IEPPresentLevelView(IIEPPresentLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
