//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentCourseSectionMarkView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentCourseSectionMarkView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentCourseSectionMark View Model as the data context for the view
        /// </summary>
        public K12StudentCourseSectionMarkView(Interfaces.IK12StudentCourseSectionMark vm)
        {
            BindingContext  = vm;
        }
    }
}
