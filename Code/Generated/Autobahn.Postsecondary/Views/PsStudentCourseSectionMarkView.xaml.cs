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
        /// Inject the IPsStudentCourseSectionMarkViewModel as the data context for the view
        /// </summary>
        public PsStudentCourseSectionMarkView(IPsStudentCourseSectionMarkViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
