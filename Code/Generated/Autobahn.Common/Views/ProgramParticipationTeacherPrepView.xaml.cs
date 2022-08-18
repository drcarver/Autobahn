//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTeacherPrepView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationTeacherPrepView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTeacherPrepView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationTeacherPrep View Model as the data context for the view
        /// </summary>
        public ProgramParticipationTeacherPrepView(Interfaces.IProgramParticipationTeacherPrep vm)
        {
            BindingContext  = vm;
        }
    }
}
