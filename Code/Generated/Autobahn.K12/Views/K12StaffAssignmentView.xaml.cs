//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StaffAssignmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StaffAssignmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StaffAssignment View Model as the data context for the view
        /// </summary>
        public K12StaffAssignmentView(Interfaces.IK12StaffAssignment vm)
        {
            BindingContext  = vm;
        }
    }
}
