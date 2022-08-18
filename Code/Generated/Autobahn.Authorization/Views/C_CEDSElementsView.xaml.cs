//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   C_CEDSElementsView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The C_CEDSElementsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_CEDSElementsView : ContentPage
    {
        /// <summary>
        /// Inject the IC_CEDSElements View Model as the data context for the view
        /// </summary>
        public C_CEDSElementsView(Interfaces.IC_CEDSElements vm)
        {
            BindingContext  = vm;
        }
    }
}
