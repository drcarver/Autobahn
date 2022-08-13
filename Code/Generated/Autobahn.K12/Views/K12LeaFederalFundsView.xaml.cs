//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaFederalFundsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaFederalFundsView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaFederalFunds View Model as the data context for the view
        /// </summary>
        public K12LeaFederalFundsView(Interfaces.IK12LeaFederalFunds vm)
        {
            BindingContext  = vm;
        }
    }
}
