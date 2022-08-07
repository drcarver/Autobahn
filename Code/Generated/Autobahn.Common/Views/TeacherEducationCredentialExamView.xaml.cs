//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherEducationCredentialExamView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The TeacherEducationCredentialExamView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherEducationCredentialExamView : ContentPage
    {
        /// <summary>
        /// Inject the ITeacherEducationCredentialExamViewModel as the data context for the view
        /// </summary>
        public TeacherEducationCredentialExamView(ITeacherEducationCredentialExamViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
