//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolGradeLevelsApprovedView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolGradeLevelsApprovedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolGradeLevelsApprovedView : ContentPage
    {
        /// <summary>
        /// Inject the K12SchoolGradeLevelsApprovedViewModel as the data context for the view
        /// </summary>
        public K12SchoolGradeLevelsApprovedView(K12SchoolGradeLevelsApprovedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
