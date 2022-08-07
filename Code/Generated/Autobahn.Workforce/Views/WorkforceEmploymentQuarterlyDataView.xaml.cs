//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataView.cs
//**********************************************************

using Autobahn.Workforce.ViewModels;

namespace Autobahn.Workforce.Views
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyDataView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkforceEmploymentQuarterlyDataView : ContentPage
    {
        /// <summary>
        /// Inject the IWorkforceEmploymentQuarterlyDataViewModel as the data context for the view
        /// </summary>
        public WorkforceEmploymentQuarterlyDataView(IWorkforceEmploymentQuarterlyDataViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
