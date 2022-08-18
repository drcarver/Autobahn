//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEvaluationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEvaluationView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffEvaluation View Model as the data context for the view
        /// </summary>
        public StaffEvaluationView(Interfaces.IStaffEvaluation vm)
        {
            BindingContext  = vm;
        }
    }
}
