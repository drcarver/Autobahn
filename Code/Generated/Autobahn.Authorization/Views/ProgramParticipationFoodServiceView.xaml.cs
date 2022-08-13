//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationFoodServiceView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProgramParticipationFoodServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationFoodServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationFoodService View Model as the data context for the view
        /// </summary>
        public ProgramParticipationFoodServiceView(Interfaces.IProgramParticipationFoodService vm)
        {
            BindingContext  = vm;
        }
    }
}
