//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionScheduleView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionScheduleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionScheduleView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionSchedule View Model as the data context for the view
        /// </summary>
        public CourseSectionScheduleView(Interfaces.ICourseSectionSchedule vm)
        {
            BindingContext  = vm;
        }
    }
}
