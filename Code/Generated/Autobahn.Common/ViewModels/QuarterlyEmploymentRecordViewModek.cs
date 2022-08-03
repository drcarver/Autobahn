//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   QuarterlyEmploymentRecordViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The QuarterlyEmploymentRecordViewModel
     /// </summary>
    public partial class QuarterlyEmploymentRecordViewModel : BindableBase, IQuarterlyEmploymentRecord
    {
#region "Backing Fields"
        // member variable for the Earnings property
        private System.Decimal? _Earnings;

        // member variable for the EmploymentNAICSCode property
        private System.String _EmploymentNAICSCode;

        // member variable for the ReferencePeriodStartDate property
        private System.DateTime? _ReferencePeriodStartDate;

        // member variable for the ReferencePeriodEndDate property
        private System.DateTime? _ReferencePeriodEndDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.Decimal? Earnings { get => _Earnings; set => SetProperty(ref _Earnings, value); }

        public System.String EmploymentNAICSCode  { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        public System.DateTime? ReferencePeriodStartDate { get => _ReferencePeriodStartDate; set => SetProperty(ref _ReferencePeriodStartDate, value); }

        public System.DateTime? ReferencePeriodEndDate { get => _ReferencePeriodEndDate; set => SetProperty(ref _ReferencePeriodEndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSourceId"/> model
        /// </summary>
        public Guid? RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocationId"/> model
        /// </summary>
        public Guid? RefEmploymentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollmentId"/> model
        /// </summary>
        public Guid? RefEmployedPriorToEnrollmentId { get; set; }

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
        public void Load(IQuarterlyEmploymentRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            Earnings = model.Earnings;
            EmploymentNAICSCode = model.EmploymentNAICSCode;
            ReferencePeriodStartDate = model.ReferencePeriodStartDate;
            ReferencePeriodEndDate = model.ReferencePeriodEndDate;
            RefERAdministrativeDataSourceId = model.RefERAdministrativeDataSourceId;
            RefEmploymentLocationId = model.RefEmploymentLocationId;
            RefEmployedPriorToEnrollmentId = model.RefEmployedPriorToEnrollmentId;
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
