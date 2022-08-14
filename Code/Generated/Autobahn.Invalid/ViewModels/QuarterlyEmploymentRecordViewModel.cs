//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   QuarterlyEmploymentRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The QuarterlyEmploymentRecordViewModel
     /// </summary>
    public partial class QuarterlyEmploymentRecordViewModel : ViewModelBase, Interfaces.IQuarterlyEmploymentRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from QuarterlyEmploymentRecord";

        // member variable for the Earnings property
        private System.Decimal? _Earnings;

        // member variable for the EmploymentNAICSCode property
        private System.String _EmploymentNAICSCode;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefEmployedPriorToEnrollmentId property
        private Guid? _RefEmployedPriorToEnrollmentId;

        // member variable for the RefEmploymentLocationId property
        private Guid? _RefEmploymentLocationId;

        // member variable for the RefERAdministrativeDataSourceId property
        private Guid? _RefERAdministrativeDataSourceId;

        // member variable for the ReferencePeriodEndDate property
        private System.DateTime? _ReferencePeriodEndDate;

        // member variable for the ReferencePeriodStartDate property
        private System.DateTime? _ReferencePeriodStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the QuarterlyEmploymentRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.Decimal? Earnings { get => _Earnings; set => SetProperty(ref _Earnings, value); }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.String EmploymentNAICSCode { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollment"/> model
        /// </summary>
        public Guid? RefEmployedPriorToEnrollmentId { get => _RefEmployedPriorToEnrollmentId; set => SetProperty(ref _RefEmployedPriorToEnrollmentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocation"/> model
        /// </summary>
        public Guid? RefEmploymentLocationId { get => _RefEmploymentLocationId; set => SetProperty(ref _RefEmploymentLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSource"/> model
        /// </summary>
        public Guid? RefERAdministrativeDataSourceId { get => _RefERAdministrativeDataSourceId; set => SetProperty(ref _RefERAdministrativeDataSourceId, value); }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.DateTime? ReferencePeriodEndDate { get => _ReferencePeriodEndDate; set => SetProperty(ref _ReferencePeriodEndDate, value); }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.DateTime? ReferencePeriodStartDate { get => _ReferencePeriodStartDate; set => SetProperty(ref _ReferencePeriodStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IQuarterlyEmploymentRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            Earnings = model.Earnings;
            EmploymentNAICSCode = model.EmploymentNAICSCode;
            PersonId = model.PersonId;
            RefEmployedPriorToEnrollmentId = model.RefEmployedPriorToEnrollmentId;
            RefEmploymentLocationId = model.RefEmploymentLocationId;
            RefERAdministrativeDataSourceId = model.RefERAdministrativeDataSourceId;
            ReferencePeriodEndDate = model.ReferencePeriodEndDate;
            ReferencePeriodStartDate = model.ReferencePeriodStartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
