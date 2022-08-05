//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   C_CEDStoNDSMappingView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The C_CEDStoNDSMappingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_CEDStoNDSMappingView : ContentPage
    {
        /// <summary>
        /// Inject the C_CEDStoNDSMappingViewModel as the data context for the view
        /// </summary>
        public C_CEDStoNDSMappingView(C_CEDStoNDSMappingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
