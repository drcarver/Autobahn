//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentCourseSectionMarkView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentCourseSectionMarkView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentCourseSectionMarkView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentCourseSectionMarkViewModel as the data context for the view
        /// </summary>
        public PsStudentCourseSectionMarkView(PsStudentCourseSectionMarkViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
