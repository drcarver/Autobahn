//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherStudentDataLinkExclusionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherStudentDataLinkExclusionView : ContentPage
    {
        /// <summary>
        /// Inject the TeacherStudentDataLinkExclusionViewModel as the data context for the view
        /// </summary>
        public TeacherStudentDataLinkExclusionView(TeacherStudentDataLinkExclusionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
