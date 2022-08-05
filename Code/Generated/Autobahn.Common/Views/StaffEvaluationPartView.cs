//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationPartView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEvaluationPartView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEvaluationPartView : ContentPage
    {
        /// <summary>
        /// Inject the StaffEvaluationPartViewModel as the data context for the view
        /// </summary>
        public StaffEvaluationPartView(StaffEvaluationPartViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
