//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentCourseSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentCourseSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentCourseSectionViewModel as the data context for the view
        /// </summary>
        public K12StudentCourseSectionView(IK12StudentCourseSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
