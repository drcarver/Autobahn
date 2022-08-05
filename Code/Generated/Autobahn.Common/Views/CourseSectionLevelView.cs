//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLevelView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionLevelView : ContentPage
    {
        /// <summary>
        /// Inject the CourseSectionLevelViewModel as the data context for the view
        /// </summary>
        public CourseSectionLevelView(CourseSectionLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
