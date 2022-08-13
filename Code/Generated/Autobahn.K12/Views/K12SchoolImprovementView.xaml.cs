//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolImprovementView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolImprovementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolImprovementView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolImprovement View Model as the data context for the view
        /// </summary>
        public K12SchoolImprovementView(Interfaces.IK12SchoolImprovement vm)
        {
            BindingContext  = vm;
        }
    }
}
