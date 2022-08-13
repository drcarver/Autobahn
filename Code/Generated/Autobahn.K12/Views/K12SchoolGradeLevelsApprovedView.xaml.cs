//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeLevelsApprovedView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolGradeLevelsApprovedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolGradeLevelsApprovedView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolGradeLevelsApproved View Model as the data context for the view
        /// </summary>
        public K12SchoolGradeLevelsApprovedView(Interfaces.IK12SchoolGradeLevelsApproved vm)
        {
            BindingContext  = vm;
        }
    }
}
