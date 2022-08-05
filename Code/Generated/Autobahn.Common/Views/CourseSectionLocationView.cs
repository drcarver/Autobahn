//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLocationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionLocationView : ContentPage
    {
        /// <summary>
        /// Inject the CourseSectionLocationViewModel as the data context for the view
        /// </summary>
        public CourseSectionLocationView(CourseSectionLocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
