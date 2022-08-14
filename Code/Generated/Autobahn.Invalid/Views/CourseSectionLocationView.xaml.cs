//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionLocationView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The CourseSectionLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionLocationView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionLocation View Model as the data context for the view
        /// </summary>
        public CourseSectionLocationView(Interfaces.ICourseSectionLocation vm)
        {
            BindingContext  = vm;
        }
    }
}
