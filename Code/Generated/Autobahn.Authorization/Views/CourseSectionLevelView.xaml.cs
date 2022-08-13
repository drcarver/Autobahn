//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CourseSectionLevelView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The CourseSectionLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionLevelView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionLevel View Model as the data context for the view
        /// </summary>
        public CourseSectionLevelView(Interfaces.ICourseSectionLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
