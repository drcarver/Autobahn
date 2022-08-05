//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEmploymentViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEmploymentViewModel
     /// </summary>
    public partial class StaffEmploymentViewModel : ViewModelBase, Interfaces.IStaffEmployment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEmployment";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the HireDate property
        private System.DateTime? _HireDate;

        // member variable for the PositionTitle property
        private System.String _PositionTitle;

        // member variable for the UnionMembershipName property
        private System.String _UnionMembershipName;

        // member variable for the WeeksEmployedPerYear property
        private System.Int32? _WeeksEmployedPerYear;

        // member variable for the StandardOccupationalClassification property
        private System.String _StandardOccupationalClassification;

        // member variable for the RefEmploymentSeparationTypeId property
        private Guid? _RefEmploymentSeparationTypeId;

        // member variable for the RefEmploymentSeparationReasonId property
        private Guid? _RefEmploymentSeparationReasonId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.DateTime? HireDate { get => _HireDate; set => SetProperty(ref _HireDate, value); }

        public System.String PositionTitle  { get => _PositionTitle; set => SetProperty(ref _PositionTitle, value); }

        public System.String UnionMembershipName  { get => _UnionMembershipName; set => SetProperty(ref _UnionMembershipName, value); }

        public System.Int32? WeeksEmployedPerYear { get => _WeeksEmployedPerYear; set => SetProperty(ref _WeeksEmployedPerYear, value); }

        public System.String StandardOccupationalClassification  { get => _StandardOccupationalClassification; set => SetProperty(ref _StandardOccupationalClassification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationTypeId"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get => _RefEmploymentSeparationTypeId; set => SetProperty(ref _RefEmploymentSeparationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationReasonId"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get => _RefEmploymentSeparationReasonId; set => SetProperty(ref _RefEmploymentSeparationReasonId, value); }

        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            HireDate = model.HireDate;
            PositionTitle = model.PositionTitle;
            UnionMembershipName = model.UnionMembershipName;
            WeeksEmployedPerYear = model.WeeksEmployedPerYear;
            StandardOccupationalClassification = model.StandardOccupationalClassification;
            RefEmploymentSeparationTypeId = model.RefEmploymentSeparationTypeId;
            RefEmploymentSeparationReasonId = model.RefEmploymentSeparationReasonId;
            FullTimeEquivalency = model.FullTimeEquivalency;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
