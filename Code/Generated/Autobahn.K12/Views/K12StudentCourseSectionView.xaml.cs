//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentCourseSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentCourseSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentCourseSection View Model as the data context for the view
        /// </summary>
        public K12StudentCourseSectionView(Interfaces.IK12StudentCourseSection vm)
        {
            BindingContext  = vm;
        }
    }
}
