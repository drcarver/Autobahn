//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaGradeLevelsApprovedView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaGradeLevelsApprovedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaGradeLevelsApprovedView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaGradeLevelsApproved View Model as the data context for the view
        /// </summary>
        public K12LeaGradeLevelsApprovedView(Interfaces.IK12LeaGradeLevelsApproved vm)
        {
            BindingContext  = vm;
        }
    }
}
