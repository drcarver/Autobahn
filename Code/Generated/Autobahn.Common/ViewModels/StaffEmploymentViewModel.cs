//**********************************************************
//* DomainName: Common Models
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

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

        // member variable for the HireDate property
        private System.DateTime? _HireDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the PositionTitle property
        private System.String _PositionTitle;

        // member variable for the RefEmploymentSeparationReasonId property
        private Guid? _RefEmploymentSeparationReasonId;

        // member variable for the RefEmploymentSeparationTypeId property
        private Guid? _RefEmploymentSeparationTypeId;

        // member variable for the StandardOccupationalClassification property
        private System.String _StandardOccupationalClassification;

        // member variable for the UnionMembershipName property
        private System.String _UnionMembershipName;

        // member variable for the WeeksEmployedPerYear property
        private System.Int32? _WeeksEmployedPerYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.DateTime? HireDate { get => _HireDate; set => SetProperty(ref _HireDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.String PositionTitle { get => _PositionTitle; set => SetProperty(ref _PositionTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationReason"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get => _RefEmploymentSeparationReasonId; set => SetProperty(ref _RefEmploymentSeparationReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationType"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get => _RefEmploymentSeparationTypeId; set => SetProperty(ref _RefEmploymentSeparationTypeId, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.String StandardOccupationalClassification { get => _StandardOccupationalClassification; set => SetProperty(ref _StandardOccupationalClassification, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.String UnionMembershipName { get => _UnionMembershipName; set => SetProperty(ref _UnionMembershipName, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.Int32? WeeksEmployedPerYear { get => _WeeksEmployedPerYear; set => SetProperty(ref _WeeksEmployedPerYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency;
            HireDate = model.HireDate;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PositionTitle = model.PositionTitle;
            RefEmploymentSeparationReasonId = model.RefEmploymentSeparationReasonId;
            RefEmploymentSeparationTypeId = model.RefEmploymentSeparationTypeId;
            StandardOccupationalClassification = model.StandardOccupationalClassification;
            UnionMembershipName = model.UnionMembershipName;
            WeeksEmployedPerYear = model.WeeksEmployedPerYear;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
