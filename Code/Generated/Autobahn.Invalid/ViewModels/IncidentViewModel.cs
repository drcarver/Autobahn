//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _IncidentCost;

        // member variable for the IncidentDate property
        private System.DateTime? _IncidentDate;

        // member variable for the IncidentDescription property
        private System.String _IncidentDescription;

        // member variable for the IncidentIdentifier property
        private System.String _IncidentIdentifier;

        // member variable for the IncidentReporterId property
        private Guid? _IncidentReporterId;

        // member variable for the IncidentTime property
        private System.TimeSpan? _IncidentTime;

        // member variable for the OrganizationPersonRoleId property
        private Guid? _OrganizationPersonRoleId;

        // member variable for the RefFirearmTypeId property
        private Guid? _RefFirearmTypeId;

        // member variable for the RefIncidentBehaviorId property
        private Guid? _RefIncidentBehaviorId;

        // member variable for the RefIncidentBehaviorSecondaryId property
        private Guid? _RefIncidentBehaviorSecondaryId;

        // member variable for the RefIncidentInjuryTypeId property
        private Guid? _RefIncidentInjuryTypeId;

        // member variable for the RefIncidentLocationId property
        private Guid? _RefIncidentLocationId;

        // member variable for the RefIncidentMultipleOffenseTypeId property
        private Guid? _RefIncidentMultipleOffenseTypeId;

        // member variable for the RefIncidentPerpetratorInjuryTypeId property
        private Guid? _RefIncidentPerpetratorInjuryTypeId;

        // member variable for the RefIncidentReporterTypeId property
        private Guid? _RefIncidentReporterTypeId;

        // member variable for the RefIncidentTimeDescriptionCodeId property
        private Guid? _RefIncidentTimeDescriptionCodeId;

        // member variable for the RefWeaponTypeId property
        private Guid? _RefWeaponTypeId;

        // member variable for the RegulationViolatedDescription property
        private System.String _RegulationViolatedDescription;

        // member variable for the RelatedToDisabilityManifestationInd property
        private System.Boolean? _RelatedToDisabilityManifestationInd;

        // member variable for the ReportedToLawEnforcementInd property
        private System.Boolean? _ReportedToLawEnforcementInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IncidentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.String IncidentCost { get => _IncidentCost; set => SetProperty(ref _IncidentCost, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.DateTime? IncidentDate { get => _IncidentDate; set => SetProperty(ref _IncidentDate, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.String IncidentDescription { get => _IncidentDescription; set => SetProperty(ref _IncidentDescription, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.String IncidentIdentifier { get => _IncidentIdentifier; set => SetProperty(ref _IncidentIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentReporter"/> model
        /// </summary>
        public Guid? IncidentReporterId { get => _IncidentReporterId; set => SetProperty(ref _IncidentReporterId, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.TimeSpan? IncidentTime { get => _IncidentTime; set => SetProperty(ref _IncidentTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFirearmType"/> model
        /// </summary>
        public Guid? RefFirearmTypeId { get => _RefFirearmTypeId; set => SetProperty(ref _RefFirearmTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehavior"/> model
        /// </summary>
        public Guid? RefIncidentBehaviorId { get => _RefIncidentBehaviorId; set => SetProperty(ref _RefIncidentBehaviorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehaviorSecondary"/> model
        /// </summary>
        public Guid? RefIncidentBehaviorSecondaryId { get => _RefIncidentBehaviorSecondaryId; set => SetProperty(ref _RefIncidentBehaviorSecondaryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentInjuryType"/> model
        /// </summary>
        public Guid? RefIncidentInjuryTypeId { get => _RefIncidentInjuryTypeId; set => SetProperty(ref _RefIncidentInjuryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentLocation"/> model
        /// </summary>
        public Guid? RefIncidentLocationId { get => _RefIncidentLocationId; set => SetProperty(ref _RefIncidentLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentMultipleOffenseType"/> model
        /// </summary>
        public Guid? RefIncidentMultipleOffenseTypeId { get => _RefIncidentMultipleOffenseTypeId; set => SetProperty(ref _RefIncidentMultipleOffenseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPerpetratorInjuryType"/> model
        /// </summary>
        public Guid? RefIncidentPerpetratorInjuryTypeId { get => _RefIncidentPerpetratorInjuryTypeId; set => SetProperty(ref _RefIncidentPerpetratorInjuryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentReporterType"/> model
        /// </summary>
        public Guid? RefIncidentReporterTypeId { get => _RefIncidentReporterTypeId; set => SetProperty(ref _RefIncidentReporterTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCode"/> model
        /// </summary>
        public Guid? RefIncidentTimeDescriptionCodeId { get => _RefIncidentTimeDescriptionCodeId; set => SetProperty(ref _RefIncidentTimeDescriptionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWeaponType"/> model
        /// </summary>
        public Guid? RefWeaponTypeId { get => _RefWeaponTypeId; set => SetProperty(ref _RefWeaponTypeId, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.String RegulationViolatedDescription { get => _RegulationViolatedDescription; set => SetProperty(ref _RegulationViolatedDescription, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.Boolean? RelatedToDisabilityManifestationInd { get => _RelatedToDisabilityManifestationInd; set => SetProperty(ref _RelatedToDisabilityManifestationInd, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.Boolean? ReportedToLawEnforcementInd { get => _ReportedToLawEnforcementInd; set => SetProperty(ref _ReportedToLawEnforcementInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncident model)
        {
            IsBusy = true;
            Id = model.Id;
            IncidentCost = model.IncidentCost;
            IncidentDate = model.IncidentDate;
            IncidentDescription = model.IncidentDescription;
            IncidentIdentifier = model.IncidentIdentifier;
            IncidentReporterId = model.IncidentReporterId;
            IncidentTime = model.IncidentTime;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefFirearmTypeId = model.RefFirearmTypeId;
            RefIncidentBehaviorId = model.RefIncidentBehaviorId;
            RefIncidentBehaviorSecondaryId = model.RefIncidentBehaviorSecondaryId;
            RefIncidentInjuryTypeId = model.RefIncidentInjuryTypeId;
            RefIncidentLocationId = model.RefIncidentLocationId;
            RefIncidentMultipleOffenseTypeId = model.RefIncidentMultipleOffenseTypeId;
            RefIncidentPerpetratorInjuryTypeId = model.RefIncidentPerpetratorInjuryTypeId;
            RefIncidentReporterTypeId = model.RefIncidentReporterTypeId;
            RefIncidentTimeDescriptionCodeId = model.RefIncidentTimeDescriptionCodeId;
            RefWeaponTypeId = model.RefWeaponTypeId;
            RegulationViolatedDescription = model.RegulationViolatedDescription;
            RelatedToDisabilityManifestationInd = model.RelatedToDisabilityManifestationInd;
            ReportedToLawEnforcementInd = model.ReportedToLawEnforcementInd;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
