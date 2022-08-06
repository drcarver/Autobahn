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
        /// Inject the IDSVersionViewModel as the data context for the view
        /// </summary>
        public IDSVersionView(IDSVersionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
