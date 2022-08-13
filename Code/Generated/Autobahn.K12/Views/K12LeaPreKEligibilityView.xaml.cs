//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibilityView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaPreKEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaPreKEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaPreKEligibility View Model as the data context for the view
        /// </summary>
        public K12LeaPreKEligibilityView(Interfaces.IK12LeaPreKEligibility vm)
        {
            BindingContext  = vm;
        }
    }
}
