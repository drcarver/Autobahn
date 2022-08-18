//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LEAPreKEligibilityView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LEAPreKEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LEAPreKEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LEAPreKEligibility View Model as the data context for the view
        /// </summary>
        public K12LEAPreKEligibilityView(Interfaces.IK12LEAPreKEligibility vm)
        {
            BindingContext  = vm;
        }
    }
}
