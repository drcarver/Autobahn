//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionViewModel as the data context for the view
        /// </summary>
        public CourseSectionView(ICourseSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
