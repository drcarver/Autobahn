//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationFoodServiceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationFoodServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationFoodServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationFoodServiceViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationFoodServiceView(IProgramParticipationFoodServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
