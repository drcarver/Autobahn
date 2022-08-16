//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AlternateName;

        // member variable for the CredentialDefDateEffective property
        private  _CredentialDefDateEffective;

        // member variable for the CredentialDefinitionTerminalDegreeIndicator property
        private  _CredentialDefinitionTerminalDegreeIndicator;

        // member variable for the CredentialNAICSIndustryType property
        private  _CredentialNAICSIndustryType;

        // member variable for the Description property
        private  _Description;

        // member variable for the EmploymentNAICSCode property
        private  _EmploymentNAICSCode;

        // member variable for the ImageUrl property
        private  _ImageUrl;

        // member variable for the JurisdictionRegion property
        private  _JurisdictionRegion;

        // member variable for the JurisdictionRegionException property
        private  _JurisdictionRegionException;

        // member variable for the Keywords property
        private  _Keywords;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCareerClusterId property
        private  _RefCareerClusterId;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCredentialDefIntendedPurposeTypeId property
        private  _RefCredentialDefIntendedPurposeTypeId;

        // member variable for the RefCredentialDefStatusTypeId property
        private  _RefCredentialDefStatusTypeId;

        // member variable for the RefCredentialDefVerificationTypeId property
        private  _RefCredentialDefVerificationTypeId;

        // member variable for the RefCtdlAudienceLevelTypeId property
        private  _RefCtdlAudienceLevelTypeId;

        // member variable for the RefONETSOCOccupationTypeId property
        private  _RefONETSOCOccupationTypeId;

        // member variable for the Title property
        private  _Title;

        // member variable for the ValidationMethodDescription property
        private  _ValidationMethodDescription;

        // member variable for the Version property
        private  _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AlternateName { get => _AlternateName; set => SetProperty(ref _AlternateName, value); }

        /// <summary>
        /// </summary>
        public  CredentialDefDateEffective { get => _CredentialDefDateEffective; set => SetProperty(ref _CredentialDefDateEffective, value); }

        /// <summary>
        /// </summary>
        public  CredentialDefinitionTerminalDegreeIndicator { get => _CredentialDefinitionTerminalDegreeIndicator; set => SetProperty(ref _CredentialDefinitionTerminalDegreeIndicator, value); }

        /// <summary>
        /// </summary>
        public  CredentialNAICSIndustryType { get => _CredentialNAICSIndustryType; set => SetProperty(ref _CredentialNAICSIndustryType, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  EmploymentNAICSCode { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        /// <summary>
        /// </summary>
        public  ImageUrl { get => _ImageUrl; set => SetProperty(ref _ImageUrl, value); }

        /// <summary>
        /// </summary>
        public  JurisdictionRegion { get => _JurisdictionRegion; set => SetProperty(ref _JurisdictionRegion, value); }

        /// <summary>
        /// </summary>
        public  JurisdictionRegionException { get => _JurisdictionRegionException; set => SetProperty(ref _JurisdictionRegionException, value); }

        /// <summary>
        /// </summary>
        public  Keywords { get => _Keywords; set => SetProperty(ref _Keywords, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public  RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefIntendedPurposeType"/> model
        /// </summary>
        public  RefCredentialDefIntendedPurposeTypeId { get => _RefCredentialDefIntendedPurposeTypeId; set => SetProperty(ref _RefCredentialDefIntendedPurposeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefStatusType"/> model
        /// </summary>
        public  RefCredentialDefStatusTypeId { get => _RefCredentialDefStatusTypeId; set => SetProperty(ref _RefCredentialDefStatusTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefVerificationType"/> model
        /// </summary>
        public  RefCredentialDefVerificationTypeId { get => _RefCredentialDefVerificationTypeId; set => SetProperty(ref _RefCredentialDefVerificationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCtdlAudienceLevelType"/> model
        /// </summary>
        public  RefCtdlAudienceLevelTypeId { get => _RefCtdlAudienceLevelTypeId; set => SetProperty(ref _RefCtdlAudienceLevelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefONETSOCOccupationType"/> model
        /// </summary>
        public  RefONETSOCOccupationTypeId { get => _RefONETSOCOccupationTypeId; set => SetProperty(ref _RefONETSOCOccupationTypeId, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// </summary>
        public  ValidationMethodDescription { get => _ValidationMethodDescription; set => SetProperty(ref _ValidationMethodDescription, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            AlternateName = model.AlternateName; // 
            CredentialDefDateEffective = model.CredentialDefDateEffective; // 
            CredentialDefinitionTerminalDegreeIndicator = model.CredentialDefinitionTerminalDegreeIndicator; // 
            CredentialNAICSIndustryType = model.CredentialNAICSIndustryType; // 
            Description = model.Description; // 
            EmploymentNAICSCode = model.EmploymentNAICSCode; // 
            ImageUrl = model.ImageUrl; // 
            JurisdictionRegion = model.JurisdictionRegion; // 
            JurisdictionRegionException = model.JurisdictionRegionException; // 
            Keywords = model.Keywords; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCareerClusterId = model.RefCareerClusterId; // 
            RefCipCodeId = model.RefCipCodeId; // 
            RefCredentialDefIntendedPurposeTypeId = model.RefCredentialDefIntendedPurposeTypeId; // 
            RefCredentialDefStatusTypeId = model.RefCredentialDefStatusTypeId; // 
            RefCredentialDefVerificationTypeId = model.RefCredentialDefVerificationTypeId; // 
            RefCtdlAudienceLevelTypeId = model.RefCtdlAudienceLevelTypeId; // 
            RefONETSOCOccupationTypeId = model.RefONETSOCOccupationTypeId; // 
            Title = model.Title; // 
            ValidationMethodDescription = model.ValidationMethodDescription; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
