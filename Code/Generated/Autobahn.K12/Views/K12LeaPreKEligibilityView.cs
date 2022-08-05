//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibilityView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaPreKEligibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaPreKEligibilityView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaPreKEligibilityViewModel as the data context for the view
        /// </summary>
        public K12LeaPreKEligibilityView(K12LeaPreKEligibilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
