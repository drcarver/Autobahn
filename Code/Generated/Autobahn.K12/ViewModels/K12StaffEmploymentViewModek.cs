//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffEmploymentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffEmploymentViewModel
     /// </summary>
    public partial class K12StaffEmploymentViewModel : BindableBase, IK12StaffEmployment
    {
#region "Backing Fields"
        // member variable for the ContractDaysOfServicePerYear property
        private System.Decimal? _ContractDaysOfServicePerYear;

        // member variable for the MepPersonnelIndicator property
        private System.Boolean? _MepPersonnelIndicator;

        // member variable for the TitleITargetedAssistanceStaffFunded property
        private System.Boolean? _TitleITargetedAssistanceStaffFunded;

        // member variable for the SalaryForTeachingAssignmentOnlyIndicator property
        private System.Boolean? _SalaryForTeachingAssignmentOnlyIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmploymentId"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        public System.Decimal? ContractDaysOfServicePerYear { get => _ContractDaysOfServicePerYear; set => SetProperty(ref _ContractDaysOfServicePerYear, value); }

        public System.Boolean? MepPersonnelIndicator { get => _MepPersonnelIndicator; set => SetProperty(ref _MepPersonnelIndicator, value); }

        public System.Boolean? TitleITargetedAssistanceStaffFunded { get => _TitleITargetedAssistanceStaffFunded; set => SetProperty(ref _TitleITargetedAssistanceStaffFunded, value); }

        public System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get => _SalaryForTeachingAssignmentOnlyIndicator; set => SetProperty(ref _SalaryForTeachingAssignmentOnlyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassificationId"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatusId"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(IK12StaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            StaffEmploymentId = model.StaffEmploymentId;
            ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear;
            MepPersonnelIndicator = model.MepPersonnelIndicator;
            TitleITargetedAssistanceStaffFunded = model.TitleITargetedAssistanceStaffFunded;
            SalaryForTeachingAssignmentOnlyIndicator = model.SalaryForTeachingAssignmentOnlyIndicator;
            RefK12StaffClassificationId = model.RefK12StaffClassificationId;
            RefEmploymentStatusId = model.RefEmploymentStatusId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
