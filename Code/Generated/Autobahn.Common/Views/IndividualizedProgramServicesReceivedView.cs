//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServicesReceivedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramServicesReceivedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramServicesReceivedView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramServicesReceivedViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramServicesReceivedView(IndividualizedProgramServicesReceivedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
