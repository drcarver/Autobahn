//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffAssignmentView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StaffAssignmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StaffAssignmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StaffAssignmentViewModel as the data context for the view
        /// </summary>
        public K12StaffAssignmentView(IK12StaffAssignmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
