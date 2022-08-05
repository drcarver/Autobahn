//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   QuarterlyEmploymentRecordViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The QuarterlyEmploymentRecordViewModel
     /// </summary>
    public partial class QuarterlyEmploymentRecordViewModel : ViewModelBase, Interfaces.IQuarterlyEmploymentRecord
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from QuarterlyEmploymentRecord";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the Earnings property
        private System.Decimal? _Earnings;

        // member variable for the EmploymentNAICSCode property
        private System.String _EmploymentNAICSCode;

        // member variable for the ReferencePeriodStartDate property
        private System.DateTime? _ReferencePeriodStartDate;

        // member variable for the ReferencePeriodEndDate property
        private System.DateTime? _ReferencePeriodEndDate;

        // member variable for the RefERAdministrativeDataSourceId property
        private Guid? _RefERAdministrativeDataSourceId;

        // member variable for the RefEmploymentLocationId property
        private Guid? _RefEmploymentLocationId;

        // member variable for the RefEmployedPriorToEnrollmentId property
        private Guid? _RefEmployedPriorToEnrollmentId;

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
        /// The title of the QuarterlyEmploymentRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.Decimal? Earnings { get => _Earnings; set => SetProperty(ref _Earnings, value); }

        public System.String EmploymentNAICSCode  { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        public System.DateTime? ReferencePeriodStartDate { get => _ReferencePeriodStartDate; set => SetProperty(ref _ReferencePeriodStartDate, value); }

        public System.DateTime? ReferencePeriodEndDate { get => _ReferencePeriodEndDate; set => SetProperty(ref _ReferencePeriodEndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSourceId"/> model
        /// </summary>
        public Guid? RefERAdministrativeDataSourceId { get => _RefERAdministrativeDataSourceId; set => SetProperty(ref _RefERAdministrativeDataSourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocationId"/> model
        /// </summary>
        public Guid? RefEmploymentLocationId { get => _RefEmploymentLocationId; set => SetProperty(ref _RefEmploymentLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollmentId"/> model
        /// </summary>
        public Guid? RefEmployedPriorToEnrollmentId { get => _RefEmployedPriorToEnrollmentId; set => SetProperty(ref _RefEmployedPriorToEnrollmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IQuarterlyEmploymentRecord model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
