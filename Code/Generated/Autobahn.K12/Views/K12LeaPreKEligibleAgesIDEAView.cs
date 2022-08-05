//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibleAgesIDEAView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEAView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaPreKEligibleAgesIDEAView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaPreKEligibleAgesIDEAViewModel as the data context for the view
        /// </summary>
        public K12LeaPreKEligibleAgesIDEAView(K12LeaPreKEligibleAgesIDEAViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
