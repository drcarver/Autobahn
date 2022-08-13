//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffAssignmentView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffAssignmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffAssignmentView : ContentPage
    {
        /// <summary>
        /// Inject the IELStaffAssignment View Model as the data context for the view
        /// </summary>
        public ELStaffAssignmentView(Interfaces.IELStaffAssignment vm)
        {
            BindingContext  = vm;
        }
    }
}
