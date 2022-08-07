//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLevelView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionLevelView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionLevelViewModel as the data context for the view
        /// </summary>
        public CourseSectionLevelView(ICourseSectionLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
