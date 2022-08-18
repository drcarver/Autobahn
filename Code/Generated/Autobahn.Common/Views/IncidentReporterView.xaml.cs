//**********************************************************
//* DomainName: Common Models
//* FileName:   IncidentReporterView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IncidentReporterView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncidentReporterView : ContentPage
    {
        /// <summary>
        /// Inject the IIncidentReporter View Model as the data context for the view
        /// </summary>
        public IncidentReporterView(Interfaces.IIncidentReporter vm)
        {
            BindingContext  = vm;
        }
    }
}
