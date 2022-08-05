//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffAssignmentView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffAssignmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffAssignmentView : ContentPage
    {
        /// <summary>
        /// Inject the ELStaffAssignmentViewModel as the data context for the view
        /// </summary>
        public ELStaffAssignmentView(ELStaffAssignmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
