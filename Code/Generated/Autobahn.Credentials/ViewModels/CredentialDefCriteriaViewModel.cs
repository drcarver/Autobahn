//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefCriteriaViewModel
     /// </summary>
    public partial class CredentialDefCriteriaViewModel : ViewModelBase, Interfaces.ICredentialDefCriteria
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefCriteria";

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the Criteria property
        private System.String _Criteria;

        // member variable for the CriteriaUrl property
        private System.String _CriteriaUrl;

        // member variable for the EstimatedDuration property
        private System.String _EstimatedDuration;

        // member variable for the MaximumDuration property
        private System.String _MaximumDuration;

        // member variable for the MinimumAge property
        private System.Int32? _MinimumAge;

        // member variable for the MinimumDuration property
        private System.String _MinimumDuration;

        // member variable for the RefCredentialDefAssessMethodTypeId property
        private Guid? _RefCredentialDefAssessMethodTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefCriteriaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String Criteria { get => _Criteria; set => SetProperty(ref _Criteria, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String CriteriaUrl { get => _CriteriaUrl; set => SetProperty(ref _CriteriaUrl, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String EstimatedDuration { get => _EstimatedDuration; set => SetProperty(ref _EstimatedDuration, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String MaximumDuration { get => _MaximumDuration; set => SetProperty(ref _MaximumDuration, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.Int32? MinimumAge { get => _MinimumAge; set => SetProperty(ref _MinimumAge, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String MinimumDuration { get => _MinimumDuration; set => SetProperty(ref _MinimumDuration, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
        /// </summary>
        public Guid? RefCredentialDefAssessMethodTypeId { get => _RefCredentialDefAssessMethodTypeId; set => SetProperty(ref _RefCredentialDefAssessMethodTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCriteria model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
            CredentialDefinitionId = model.CredentialDefinitionId;
            Criteria = model.Criteria;
            CriteriaUrl = model.CriteriaUrl;
            EstimatedDuration = model.EstimatedDuration;
            MaximumDuration = model.MaximumDuration;
            MinimumAge = model.MinimumAge;
            MinimumDuration = model.MinimumDuration;
            RefCredentialDefAssessMethodTypeId = model.RefCredentialDefAssessMethodTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
