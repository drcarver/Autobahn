//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CourseView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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
