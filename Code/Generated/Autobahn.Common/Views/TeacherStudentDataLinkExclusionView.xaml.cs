//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherStudentDataLinkExclusionView : ContentPage
    {
        /// <summary>
        /// Inject the ITeacherStudentDataLinkExclusion View Model as the data context for the view
        /// </summary>
        public TeacherStudentDataLinkExclusionView(Interfaces.ITeacherStudentDataLinkExclusion vm)
        {
            BindingContext  = vm;
        }
    }
}
