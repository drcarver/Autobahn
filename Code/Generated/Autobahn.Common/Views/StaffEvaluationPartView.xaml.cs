//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEvaluationPartView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEvaluationPartView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffEvaluationPart View Model as the data context for the view
        /// </summary>
        public StaffEvaluationPartView(Interfaces.IStaffEvaluationPart vm)
        {
            BindingContext  = vm;
        }
    }
}
