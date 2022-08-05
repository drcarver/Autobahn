//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffTechnicalAssistanceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffTechnicalAssistanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffTechnicalAssistanceView : ContentPage
    {
        /// <summary>
        /// Inject the StaffTechnicalAssistanceViewModel as the data context for the view
        /// </summary>
        public StaffTechnicalAssistanceView(StaffTechnicalAssistanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
