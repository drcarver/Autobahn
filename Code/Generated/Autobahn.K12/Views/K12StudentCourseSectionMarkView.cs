//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionMarkView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentCourseSectionMarkView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentCourseSectionMarkView : ContentPage
    {
        /// <summary>
        /// Inject the K12StudentCourseSectionMarkViewModel as the data context for the view
        /// </summary>
        public K12StudentCourseSectionMarkView(K12StudentCourseSectionMarkViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
