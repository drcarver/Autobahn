//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseView.cs
//**********************************************************

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeCourseView : ContentPage
    {
        /// <summary>
        /// Inject the IAeCourse View Model as the data context for the view
        /// </summary>
        public AeCourseView(Interfaces.IAeCourse vm)
        {
            BindingContext  = vm;
        }
    }
}
