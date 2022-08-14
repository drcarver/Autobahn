//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The CourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseView : ContentPage
    {
        /// <summary>
        /// Inject the ICourse View Model as the data context for the view
        /// </summary>
        public CourseView(Interfaces.ICourse vm)
        {
            BindingContext  = vm;
        }
    }
}
