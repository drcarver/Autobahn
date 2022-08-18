//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaFederalReportingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaFederalReportingView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaFederalReporting View Model as the data context for the view
        /// </summary>
        public K12LeaFederalReportingView(Interfaces.IK12LeaFederalReporting vm)
        {
            BindingContext  = vm;
        }
    }
}
