//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentEmploymentViewModel
     /// </summary>
    public partial class PsStudentEmploymentViewModel : ViewModelBase, Interfaces.IPsStudentEmployment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentEmployment";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the EmploymentNaicsCode property
        private System.String _EmploymentNaicsCode;

        // member variable for the RefEmployedWhileEnrolledId property
        private Guid? _RefEmployedWhileEnrolledId;

        // member variable for the RefEmployedAfterExitId property
        private Guid? _RefEmployedAfterExitId;

        // member variable for the RefEmploymentStatusWhileEnrolledId property
        private Guid? _RefEmploymentStatusWhileEnrolledId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String EmploymentNaicsCode  { get => _EmploymentNaicsCode; set => SetProperty(ref _EmploymentNaicsCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolledId"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExitId"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatusWhileEnrolledId"/> model
        /// </summary>
        public Guid? RefEmploymentStatusWhileEnrolledId { get => _RefEmploymentStatusWhileEnrolledId; set => SetProperty(ref _RefEmploymentStatusWhileEnrolledId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            EmploymentNaicsCode = model.EmploymentNaicsCode;
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId;
            RefEmployedAfterExitId = model.RefEmployedAfterExitId;
            RefEmploymentStatusWhileEnrolledId = model.RefEmploymentStatusWhileEnrolledId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
