//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   QuarterlyEmploymentRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _Earnings;

        // member variable for the EmploymentNAICSCode property
        private  _EmploymentNAICSCode;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmployedPriorToEnrollmentId property
        private  _RefEmployedPriorToEnrollmentId;

        // member variable for the RefEmploymentLocationId property
        private  _RefEmploymentLocationId;

        // member variable for the RefERAdministrativeDataSourceId property
        private  _RefERAdministrativeDataSourceId;

        // member variable for the ReferencePeriodEndDate property
        private  _ReferencePeriodEndDate;

        // member variable for the ReferencePeriodStartDate property
        private  _ReferencePeriodStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Earnings { get => _Earnings; set => SetProperty(ref _Earnings, value); }

        /// <summary>
        /// </summary>
        public  EmploymentNAICSCode { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollment"/> model
        /// </summary>
        public  RefEmployedPriorToEnrollmentId { get => _RefEmployedPriorToEnrollmentId; set => SetProperty(ref _RefEmployedPriorToEnrollmentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocation"/> model
        /// </summary>
        public  RefEmploymentLocationId { get => _RefEmploymentLocationId; set => SetProperty(ref _RefEmploymentLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSource"/> model
        /// </summary>
        public  RefERAdministrativeDataSourceId { get => _RefERAdministrativeDataSourceId; set => SetProperty(ref _RefERAdministrativeDataSourceId, value); }

        /// <summary>
        /// </summary>
        public  ReferencePeriodEndDate { get => _ReferencePeriodEndDate; set => SetProperty(ref _ReferencePeriodEndDate, value); }

        /// <summary>
        /// </summary>
        public  ReferencePeriodStartDate { get => _ReferencePeriodStartDate; set => SetProperty(ref _ReferencePeriodStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IQuarterlyEmploymentRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            Earnings = model.Earnings; // 
            EmploymentNAICSCode = model.EmploymentNAICSCode; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmployedPriorToEnrollmentId = model.RefEmployedPriorToEnrollmentId; // 
            RefEmploymentLocationId = model.RefEmploymentLocationId; // 
            RefERAdministrativeDataSourceId = model.RefERAdministrativeDataSourceId; // 
            ReferencePeriodEndDate = model.ReferencePeriodEndDate; // 
            ReferencePeriodStartDate = model.ReferencePeriodStartDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
