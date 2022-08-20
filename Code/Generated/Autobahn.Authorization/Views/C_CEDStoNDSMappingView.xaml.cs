//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   C_CEDStoNDSMappingView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The C_CEDStoNDSMappingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_CEDStoNDSMappingView : ContentPage
    {
        /// <summary>
        /// Inject the IC_CEDStoNDSMapping View Model as the data context for the view
        /// </summary>
        public C_CEDStoNDSMappingView(Interfaces.IC_CEDStoNDSMapping vm)
        {
            BindingContext  = vm;
        }
    }
}