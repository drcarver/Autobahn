//**********************************************************
//* DomainName: Autobahn.Credentials
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

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

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
        /// The title of the CredentialDefCriteriaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        public System.String Criteria  { get => _Criteria; set => SetProperty(ref _Criteria, value); }

        public System.String CriteriaUrl  { get => _CriteriaUrl; set => SetProperty(ref _CriteriaUrl, value); }

        public System.String EstimatedDuration  { get => _EstimatedDuration; set => SetProperty(ref _EstimatedDuration, value); }

        public System.String MaximumDuration  { get => _MaximumDuration; set => SetProperty(ref _MaximumDuration, value); }

        public System.Int32? MinimumAge { get => _MinimumAge; set => SetProperty(ref _MinimumAge, value); }

        public System.String MinimumDuration  { get => _MinimumDuration; set => SetProperty(ref _MinimumDuration, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodTypeId"/> model
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
            CredentialDefinitionId = model.CredentialDefinitionId;
            CompetencySetId = model.CompetencySetId;
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
