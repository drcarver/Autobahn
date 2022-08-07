//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDSVersionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IDSVersionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IDSVersionView : ContentPage
    {
        /// <summary>
        /// Inject the IIDSVersionViewModel as the data context for the view
        /// </summary>
        public IDSVersionView(IIDSVersionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
