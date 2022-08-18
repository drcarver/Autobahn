//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataView.cs
//**********************************************************

namespace Autobahn.Workforce.Views
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyDataView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkforceEmploymentQuarterlyDataView : ContentPage
    {
        /// <summary>
        /// Inject the IWorkforceEmploymentQuarterlyData View Model as the data context for the view
        /// </summary>
        public WorkforceEmploymentQuarterlyDataView(Interfaces.IWorkforceEmploymentQuarterlyData vm)
        {
            BindingContext  = vm;
        }
    }
}
