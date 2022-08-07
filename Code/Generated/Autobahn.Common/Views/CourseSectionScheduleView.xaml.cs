//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionScheduleView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionScheduleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionScheduleView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionScheduleViewModel as the data context for the view
        /// </summary>
        public CourseSectionScheduleView(ICourseSectionScheduleViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
