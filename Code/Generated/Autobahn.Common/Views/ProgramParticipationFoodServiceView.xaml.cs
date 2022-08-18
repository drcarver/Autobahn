//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationFoodServiceView.cs
//**********************************************************

namespace Autobahn.Common.Views
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
