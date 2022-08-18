//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentCourseSectionMarkView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentCourseSectionMarkView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentCourseSectionMark View Model as the data context for the view
        /// </summary>
        public PsStudentCourseSectionMarkView(Interfaces.IPsStudentCourseSectionMark vm)
        {
            BindingContext  = vm;
        }
    }
}
