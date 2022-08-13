//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CourseSectionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The CourseSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSection View Model as the data context for the view
        /// </summary>
        public CourseSectionView(Interfaces.ICourseSection vm)
        {
            BindingContext  = vm;
        }
    }
}
