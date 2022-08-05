//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionView : ContentPage
    {
        /// <summary>
        /// Inject the CourseSectionViewModel as the data context for the view
        /// </summary>
        public CourseSectionView(CourseSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
