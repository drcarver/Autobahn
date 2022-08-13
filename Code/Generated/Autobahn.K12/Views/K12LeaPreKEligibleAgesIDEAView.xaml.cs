//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibleAgesIDEAView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEAView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaPreKEligibleAgesIDEAView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaPreKEligibleAgesIDEA View Model as the data context for the view
        /// </summary>
        public K12LeaPreKEligibleAgesIDEAView(Interfaces.IK12LeaPreKEligibleAgesIDEA vm)
        {
            BindingContext  = vm;
        }
    }
}
