//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEmploymentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEmploymentViewModel
     /// </summary>
    public partial class StaffEmploymentViewModel : BindableBase, IStaffEmployment
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.DateTime? HireDate { get => _HireDate; set => SetProperty(ref _HireDate, value); }

        public System.String PositionTitle  { get => _PositionTitle; set => SetProperty(ref _PositionTitle, value); }

        public System.String UnionMembershipName  { get => _UnionMembershipName; set => SetProperty(ref _UnionMembershipName, value); }

        public System.Int32? WeeksEmployedPerYear { get => _WeeksEmployedPerYear; set => SetProperty(ref _WeeksEmployedPerYear, value); }

        public System.String StandardOccupationalClassification  { get => _StandardOccupationalClassification; set => SetProperty(ref _StandardOccupationalClassification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationTypeId"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationReasonId"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IStaffEmployment model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            FullTimeEquivalency = model.FullTimeEquivalency;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
