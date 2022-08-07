//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTeacherPrepView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationTeacherPrepView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTeacherPrepView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationTeacherPrepViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationTeacherPrepView(IProgramParticipationTeacherPrepViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
