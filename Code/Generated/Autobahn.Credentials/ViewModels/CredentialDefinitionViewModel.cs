//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefinitionViewModel
     /// </summary>
    public partial class CredentialDefinitionViewModel : ViewModelBase, Interfaces.ICredentialDefinition
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefinition";

        // member variable for the AlternateName property
        private System.String _AlternateName;

        // member variable for the CredentialNAICSIndustryType property
        private System.String _CredentialNAICSIndustryType;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the EmploymentNAICSCode property
        private System.String _EmploymentNAICSCode;

        // member variable for the ImageUrl property
        private System.String _ImageUrl;

        // member variable for the JurisdictionRegion property
        private System.String _JurisdictionRegion;

        // member variable for the JurisdictionRegionException property
        private System.String _JurisdictionRegionException;

        // member variable for the Keywords property
        private System.String _Keywords;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the ValidationMethodDescription property
        private System.String _ValidationMethodDescription;

        // member variable for the Version property
        private System.Decimal? _Version;

        // member variable for the CredentialDefDateEffective property
        private System.DateTime? _CredentialDefDateEffective;

        // member variable for the RefCareerClusterId property
        private Guid? _RefCareerClusterId;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCredentialDefIntendedPurposeTypeId property
        private Guid? _RefCredentialDefIntendedPurposeTypeId;

        // member variable for the RefCredentialDefStatusTypeId property
        private Guid? _RefCredentialDefStatusTypeId;

        // member variable for the RefCredentialDefVerificationTypeId property
        private Guid? _RefCredentialDefVerificationTypeId;

        // member variable for the RefONETSOCOccupationTypeId property
        private Guid? _RefONETSOCOccupationTypeId;

        // member variable for the RefCTDLAudienceLevelTypeId property
        private Guid? _RefCTDLAudienceLevelTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the CredentialDefinitionTerminalDegreeIndicator property
        private System.Boolean? _CredentialDefinitionTerminalDegreeIndicator;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefinitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String AlternateName  { get => _AlternateName; set => SetProperty(ref _AlternateName, value); }

        public System.String CredentialNAICSIndustryType  { get => _CredentialNAICSIndustryType; set => SetProperty(ref _CredentialNAICSIndustryType, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String EmploymentNAICSCode  { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        public System.String ImageUrl  { get => _ImageUrl; set => SetProperty(ref _ImageUrl, value); }

        public System.String JurisdictionRegion  { get => _JurisdictionRegion; set => SetProperty(ref _JurisdictionRegion, value); }

        public System.String JurisdictionRegionException  { get => _JurisdictionRegionException; set => SetProperty(ref _JurisdictionRegionException, value); }

        public System.String Keywords  { get => _Keywords; set => SetProperty(ref _Keywords, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String ValidationMethodDescription  { get => _ValidationMethodDescription; set => SetProperty(ref _ValidationMethodDescription, value); }

        public System.Decimal? Version { get => _Version; set => SetProperty(ref _Version, value); }

        public System.DateTime? CredentialDefDateEffective { get => _CredentialDefDateEffective; set => SetProperty(ref _CredentialDefDateEffective, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerClusterId"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefIntendedPurposeTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefIntendedPurposeTypeId { get => _RefCredentialDefIntendedPurposeTypeId; set => SetProperty(ref _RefCredentialDefIntendedPurposeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefStatusTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefStatusTypeId { get => _RefCredentialDefStatusTypeId; set => SetProperty(ref _RefCredentialDefStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefVerificationTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefVerificationTypeId { get => _RefCredentialDefVerificationTypeId; set => SetProperty(ref _RefCredentialDefVerificationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefONETSOCOccupationTypeId"/> model
        /// </summary>
        public Guid? RefONETSOCOccupationTypeId { get => _RefONETSOCOccupationTypeId; set => SetProperty(ref _RefONETSOCOccupationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLAudienceLevelTypeId"/> model
        /// </summary>
        public Guid? RefCTDLAudienceLevelTypeId { get => _RefCTDLAudienceLevelTypeId; set => SetProperty(ref _RefCTDLAudienceLevelTypeId, value); }

        public System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get => _CredentialDefinitionTerminalDegreeIndicator; set => SetProperty(ref _CredentialDefinitionTerminalDegreeIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            AlternateName = model.AlternateName;
            CredentialNAICSIndustryType = model.CredentialNAICSIndustryType;
            Description = model.Description;
            EmploymentNAICSCode = model.EmploymentNAICSCode;
            ImageUrl = model.ImageUrl;
            JurisdictionRegion = model.JurisdictionRegion;
            JurisdictionRegionException = model.JurisdictionRegionException;
            Keywords = model.Keywords;
            Title = model.Title;
            ValidationMethodDescription = model.ValidationMethodDescription;
            Version = model.Version;
            CredentialDefDateEffective = model.CredentialDefDateEffective;
            RefCareerClusterId = model.RefCareerClusterId;
            RefCipCodeId = model.RefCipCodeId;
            RefCredentialDefIntendedPurposeTypeId = model.RefCredentialDefIntendedPurposeTypeId;
            RefCredentialDefStatusTypeId = model.RefCredentialDefStatusTypeId;
            RefCredentialDefVerificationTypeId = model.RefCredentialDefVerificationTypeId;
            RefONETSOCOccupationTypeId = model.RefONETSOCOccupationTypeId;
            RefCTDLAudienceLevelTypeId = model.RefCTDLAudienceLevelTypeId;
            CredentialDefinitionTerminalDegreeIndicator = model.CredentialDefinitionTerminalDegreeIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
