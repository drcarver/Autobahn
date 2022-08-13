//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationSpecialEducationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProgramParticipationSpecialEducationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationSpecialEducationView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationSpecialEducation View Model as the data context for the view
        /// </summary>
        public ProgramParticipationSpecialEducationView(Interfaces.IProgramParticipationSpecialEducation vm)
        {
            BindingContext  = vm;
        }
    }
}
