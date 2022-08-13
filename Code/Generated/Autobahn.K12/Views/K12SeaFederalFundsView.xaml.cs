//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundsView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaFederalFundsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaFederalFundsView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SeaFederalFunds View Model as the data context for the view
        /// </summary>
        public K12SeaFederalFundsView(Interfaces.IK12SeaFederalFunds vm)
        {
            BindingContext  = vm;
        }
    }
}
