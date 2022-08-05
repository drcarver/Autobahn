//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   C_CEDSElementsView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The C_CEDSElementsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_CEDSElementsView : ContentPage
    {
        /// <summary>
        /// Inject the C_CEDSElementsViewModel as the data context for the view
        /// </summary>
        public C_CEDSElementsView(C_CEDSElementsViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
