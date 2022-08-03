//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefinitionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefinitionViewModel
     /// </summary>
    public partial class CredentialDefinitionViewModel : BindableBase, ICredentialDefinition
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the CredentialDefinitionTerminalDegreeIndicator property
        private System.Boolean? _CredentialDefinitionTerminalDegreeIndicator;

#endregion

#region Properties
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
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefIntendedPurposeTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefStatusTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefVerificationTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefONETSOCOccupationTypeId"/> model
        /// </summary>
        public Guid? RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLAudienceLevelTypeId"/> model
        /// </summary>
        public Guid? RefCTDLAudienceLevelTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get => _CredentialDefinitionTerminalDegreeIndicator; set => SetProperty(ref _CredentialDefinitionTerminalDegreeIndicator, value); }

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
        public void Load(ICredentialDefinition model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            CredentialDefinitionTerminalDegreeIndicator = model.CredentialDefinitionTerminalDegreeIndicator;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
