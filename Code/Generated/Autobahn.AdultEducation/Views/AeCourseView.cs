//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeCourseView.cs
//**********************************************************

using Autobahn.AdultEducation.ViewModels;

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeCourseView : ContentPage
    {
        /// <summary>
        /// Inject the AeCourseViewModel as the data context for the view
        /// </summary>
        public AeCourseView(AeCourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
