//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEvaluationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEvaluationView : ContentPage
    {
        /// <summary>
        /// Inject the StaffEvaluationViewModel as the data context for the view
        /// </summary>
        public StaffEvaluationView(StaffEvaluationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
