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
        /// Inject the IIndividualizedProgramServicesReceivedViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramServicesReceivedView(IIndividualizedProgramServicesReceivedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
