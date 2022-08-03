//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IncidentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IncidentViewModel
     /// </summary>
    public partial class IncidentViewModel : BindableBase, IIncident
    {
#region "Backing Fields"
        // member variable for the IncidentIdentifier property
        private System.String _IncidentIdentifier;

        // member variable for the IncidentDate property
        private System.DateTime? _IncidentDate;

        // member variable for the IncidentTime property
        private System.TimeSpan? _IncidentTime;

        // member variable for the IncidentDescription property
        private System.String _IncidentDescription;

        // member variable for the IncidentCost property
        private System.String _IncidentCost;

        // member variable for the RegulationViolatedDescription property
        private System.String _RegulationViolatedDescription;

        // member variable for the RelatedToDisabilityManifestationInd property
        private System.Boolean? _RelatedToDisabilityManifestationInd;

        // member variable for the ReportedToLawEnforcementInd property
        private System.Boolean? _ReportedToLawEnforcementInd;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String IncidentIdentifier  { get => _IncidentIdentifier; set => SetProperty(ref _IncidentIdentifier, value); }

        public System.DateTime? IncidentDate { get => _IncidentDate; set => SetProperty(ref _IncidentDate, value); }

        public System.TimeSpan? IncidentTime { get => _IncidentTime; set => SetProperty(ref _IncidentTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCodeId"/> model
        /// </summary>
        public Guid? RefIncidentTimeDescriptionCodeId { get; set; }

        public System.String IncidentDescription  { get => _IncidentDescription; set => SetProperty(ref _IncidentDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehaviorId"/> model
        /// </summary>
        public Guid? RefIncidentBehaviorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehaviorSecondaryId"/> model
        /// </summary>
        public Guid? RefIncidentBehaviorSecondaryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentInjuryTypeId"/> model
        /// </summary>
        public Guid? RefIncidentInjuryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWeaponTypeId"/> model
        /// </summary>
        public Guid? RefWeaponTypeId { get; set; }

        public System.String IncidentCost  { get => _IncidentCost; set => SetProperty(ref _IncidentCost, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentReporterId"/> model
        /// </summary>
        public Guid? IncidentReporterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentReporterTypeId"/> model
        /// </summary>
        public Guid? RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentLocationId"/> model
        /// </summary>
        public Guid? RefIncidentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFirearmTypeId"/> model
        /// </summary>
        public Guid? RefFirearmTypeId { get; set; }

        public System.String RegulationViolatedDescription  { get => _RegulationViolatedDescription; set => SetProperty(ref _RegulationViolatedDescription, value); }

        public System.Boolean? RelatedToDisabilityManifestationInd { get => _RelatedToDisabilityManifestationInd; set => SetProperty(ref _RelatedToDisabilityManifestationInd, value); }

        public System.Boolean? ReportedToLawEnforcementInd { get => _ReportedToLawEnforcementInd; set => SetProperty(ref _ReportedToLawEnforcementInd, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentMultipleOffenseTypeId"/> model
        /// </summary>
        public Guid? RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPerpetratorInjuryTypeId"/> model
        /// </summary>
        public Guid? RefIncidentPerpetratorInjuryTypeId { get; set; }

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
        public void Load(IIncident model)
        {
            IsBusy = true;
            Id = model.Id;
            IncidentIdentifier = model.IncidentIdentifier;
            IncidentDate = model.IncidentDate;
            IncidentTime = model.IncidentTime;
            RefIncidentTimeDescriptionCodeId = model.RefIncidentTimeDescriptionCodeId;
            IncidentDescription = model.IncidentDescription;
            RefIncidentBehaviorId = model.RefIncidentBehaviorId;
            RefIncidentBehaviorSecondaryId = model.RefIncidentBehaviorSecondaryId;
            RefIncidentInjuryTypeId = model.RefIncidentInjuryTypeId;
            RefWeaponTypeId = model.RefWeaponTypeId;
            IncidentCost = model.IncidentCost;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            IncidentReporterId = model.IncidentReporterId;
            RefIncidentReporterTypeId = model.RefIncidentReporterTypeId;
            RefIncidentLocationId = model.RefIncidentLocationId;
            RefFirearmTypeId = model.RefFirearmTypeId;
            RegulationViolatedDescription = model.RegulationViolatedDescription;
            RelatedToDisabilityManifestationInd = model.RelatedToDisabilityManifestationInd;
            ReportedToLawEnforcementInd = model.ReportedToLawEnforcementInd;
            RefIncidentMultipleOffenseTypeId = model.RefIncidentMultipleOffenseTypeId;
            RefIncidentPerpetratorInjuryTypeId = model.RefIncidentPerpetratorInjuryTypeId;
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
