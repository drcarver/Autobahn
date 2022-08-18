//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The TeacherEducationCredentialExamView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherEducationCredentialExamView : ContentPage
    {
        /// <summary>
        /// Inject the ITeacherEducationCredentialExam View Model as the data context for the view
        /// </summary>
        public TeacherEducationCredentialExamView(Interfaces.ITeacherEducationCredentialExam vm)
        {
            BindingContext  = vm;
        }
    }
}
