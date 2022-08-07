//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolImprovementView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolImprovementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolImprovementView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolImprovementViewModel as the data context for the view
        /// </summary>
        public K12SchoolImprovementView(IK12SchoolImprovementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
