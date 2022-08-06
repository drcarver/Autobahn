//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalReportingView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaFederalReportingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaFederalReportingView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaFederalReportingViewModel as the data context for the view
        /// </summary>
        public K12LeaFederalReportingView(K12LeaFederalReportingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
