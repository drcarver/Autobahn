//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseViewModel as the data context for the view
        /// </summary>
        public CourseView(ICourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
