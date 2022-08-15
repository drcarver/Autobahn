//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceEventViewModel
     /// </summary>
    public partial class RoleAttendanceEventViewModel : ViewModelBase, Interfaces.IRoleAttendanceEvent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendanceEvent";

        // member variable for the RefAttendanceStatusId property
        private Guid? _RefAttendanceStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleAttendanceEventViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Attendance Status")]
        public Guid? RefAttendanceStatusId { get => _RefAttendanceStatusId; set => SetProperty(ref _RefAttendanceStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendanceEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAttendanceStatusId = model.RefAttendanceStatusId; // Attendance Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
