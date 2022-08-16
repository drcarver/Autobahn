//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IncidentViewModel
     /// </summary>
    public partial class IncidentViewModel : ViewModelBase, Interfaces.IIncident
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Incident";

        // member variable for the IncidentCost property
        private  _IncidentCost;

        // member variable for the IncidentDate property
        private  _IncidentDate;

        // member variable for the IncidentDescription property
        private  _IncidentDescription;

        // member variable for the IncidentIdentifier property
        private Guid? _IncidentIdentifier;

        // member variable for the IncidentReporterId property
        private  _IncidentReporterId;

        // member variable for the IncidentTime property
        private  _IncidentTime;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFirearmTypeId property
        private  _RefFirearmTypeId;

        // member variable for the RefIncidentBehaviorId property
        private  _RefIncidentBehaviorId;

        // member variable for the RefIncidentBehaviorSecondaryId property
        private  _RefIncidentBehaviorSecondaryId;

        // member variable for the RefIncidentInjuryTypeId property
        private  _RefIncidentInjuryTypeId;

        // member variable for the RefIncidentLocationId property
        private  _RefIncidentLocationId;

        // member variable for the RefIncidentMultipleOffenseTypeId property
        private  _RefIncidentMultipleOffenseTypeId;

        // member variable for the RefIncidentPerpetratorInjuryTypeId property
        private  _RefIncidentPerpetratorInjuryTypeId;

        // member variable for the RefIncidentReporterTypeId property
        private  _RefIncidentReporterTypeId;

        // member variable for the RefIncidentTimeDescriptionCodeId property
        private  _RefIncidentTimeDescriptionCodeId;

        // member variable for the RefWeaponTypeId property
        private  _RefWeaponTypeId;

        // member variable for the RegulationViolatedDescription property
        private  _RegulationViolatedDescription;

        // member variable for the RelatedToDisabilityManifestationInd property
        private  _RelatedToDisabilityManifestationInd;

        // member variable for the ReportedToLawEnforcementInd property
        private  _ReportedToLawEnforcementInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  IncidentCost { get => _IncidentCost; set => SetProperty(ref _IncidentCost, value); }

        /// <summary>
        /// </summary>
        public  IncidentDate { get => _IncidentDate; set => SetProperty(ref _IncidentDate, value); }

        /// <summary>
        /// </summary>
        public  IncidentDescription { get => _IncidentDescription; set => SetProperty(ref _IncidentDescription, value); }

        /// <summary>
        /// </summary>
        public Guid? IncidentIdentifier { get => _IncidentIdentifier; set => SetProperty(ref _IncidentIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentReporter"/> model
        /// </summary>
        public  IncidentReporterId { get => _IncidentReporterId; set => SetProperty(ref _IncidentReporterId, value); }

        /// <summary>
        /// </summary>
        public  IncidentTime { get => _IncidentTime; set => SetProperty(ref _IncidentTime, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFirearmType"/> model
        /// </summary>
        public  RefFirearmTypeId { get => _RefFirearmTypeId; set => SetProperty(ref _RefFirearmTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehavior"/> model
        /// </summary>
        public  RefIncidentBehaviorId { get => _RefIncidentBehaviorId; set => SetProperty(ref _RefIncidentBehaviorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehaviorSecondary"/> model
        /// </summary>
        public  RefIncidentBehaviorSecondaryId { get => _RefIncidentBehaviorSecondaryId; set => SetProperty(ref _RefIncidentBehaviorSecondaryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentInjuryType"/> model
        /// </summary>
        public  RefIncidentInjuryTypeId { get => _RefIncidentInjuryTypeId; set => SetProperty(ref _RefIncidentInjuryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentLocation"/> model
        /// </summary>
        public  RefIncidentLocationId { get => _RefIncidentLocationId; set => SetProperty(ref _RefIncidentLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentMultipleOffenseType"/> model
        /// </summary>
        public  RefIncidentMultipleOffenseTypeId { get => _RefIncidentMultipleOffenseTypeId; set => SetProperty(ref _RefIncidentMultipleOffenseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPerpetratorInjuryType"/> model
        /// </summary>
        public  RefIncidentPerpetratorInjuryTypeId { get => _RefIncidentPerpetratorInjuryTypeId; set => SetProperty(ref _RefIncidentPerpetratorInjuryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentReporterType"/> model
        /// </summary>
        public  RefIncidentReporterTypeId { get => _RefIncidentReporterTypeId; set => SetProperty(ref _RefIncidentReporterTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCode"/> model
        /// </summary>
        public  RefIncidentTimeDescriptionCodeId { get => _RefIncidentTimeDescriptionCodeId; set => SetProperty(ref _RefIncidentTimeDescriptionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWeaponType"/> model
        /// </summary>
        public  RefWeaponTypeId { get => _RefWeaponTypeId; set => SetProperty(ref _RefWeaponTypeId, value); }

        /// <summary>
        /// </summary>
        public  RegulationViolatedDescription { get => _RegulationViolatedDescription; set => SetProperty(ref _RegulationViolatedDescription, value); }

        /// <summary>
        /// </summary>
        public  RelatedToDisabilityManifestationInd { get => _RelatedToDisabilityManifestationInd; set => SetProperty(ref _RelatedToDisabilityManifestationInd, value); }

        /// <summary>
        /// </summary>
        public  ReportedToLawEnforcementInd { get => _ReportedToLawEnforcementInd; set => SetProperty(ref _ReportedToLawEnforcementInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncident model)
        {
            IsBusy = true;
            Id = model.Id;
            IncidentCost = model.IncidentCost; // 
            IncidentDate = model.IncidentDate; // 
            IncidentDescription = model.IncidentDescription; // 
            IncidentIdentifier = model.IncidentIdentifier; // 
            IncidentReporterId = model.IncidentReporterId; // 
            IncidentTime = model.IncidentTime; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFirearmTypeId = model.RefFirearmTypeId; // 
            RefIncidentBehaviorId = model.RefIncidentBehaviorId; // 
            RefIncidentBehaviorSecondaryId = model.RefIncidentBehaviorSecondaryId; // 
            RefIncidentInjuryTypeId = model.RefIncidentInjuryTypeId; // 
            RefIncidentLocationId = model.RefIncidentLocationId; // 
            RefIncidentMultipleOffenseTypeId = model.RefIncidentMultipleOffenseTypeId; // 
            RefIncidentPerpetratorInjuryTypeId = model.RefIncidentPerpetratorInjuryTypeId; // 
            RefIncidentReporterTypeId = model.RefIncidentReporterTypeId; // 
            RefIncidentTimeDescriptionCodeId = model.RefIncidentTimeDescriptionCodeId; // 
            RefWeaponTypeId = model.RefWeaponTypeId; // 
            RegulationViolatedDescription = model.RegulationViolatedDescription; // 
            RelatedToDisabilityManifestationInd = model.RelatedToDisabilityManifestationInd; // 
            ReportedToLawEnforcementInd = model.ReportedToLawEnforcementInd; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
