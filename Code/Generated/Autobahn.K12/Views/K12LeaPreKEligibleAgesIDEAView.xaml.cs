//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LEAPreKEligibleAgesIDEAView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LEAPreKEligibleAgesIDEAView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LEAPreKEligibleAgesIDEAView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LEAPreKEligibleAgesIDEA View Model as the data context for the view
        /// </summary>
        public K12LEAPreKEligibleAgesIDEAView(Interfaces.IK12LEAPreKEligibleAgesIDEA vm)
        {
            BindingContext  = vm;
        }
    }
}
