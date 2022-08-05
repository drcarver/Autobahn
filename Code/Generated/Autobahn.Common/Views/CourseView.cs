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
        /// Inject the CourseViewModel as the data context for the view
        /// </summary>
        public CourseView(CourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
