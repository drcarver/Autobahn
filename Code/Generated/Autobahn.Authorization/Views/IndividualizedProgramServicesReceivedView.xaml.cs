//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramServicesReceivedView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The IndividualizedProgramServicesReceivedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramServicesReceivedView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramServicesReceived View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramServicesReceivedView(Interfaces.IIndividualizedProgramServicesReceived vm)
        {
            BindingContext  = vm;
        }
    }
}
