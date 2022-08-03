//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCriteriaViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefCriteriaViewModel
     /// </summary>
    public partial class CredentialDefCriteriaViewModel : BindableBase, ICredentialDefCriteria
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        public System.String Criteria  { get => _Criteria; set => SetProperty(ref _Criteria, value); }

        public System.String CriteriaUrl  { get => _CriteriaUrl; set => SetProperty(ref _CriteriaUrl, value); }

        public System.String EstimatedDuration  { get => _EstimatedDuration; set => SetProperty(ref _EstimatedDuration, value); }

        public System.String MaximumDuration  { get => _MaximumDuration; set => SetProperty(ref _MaximumDuration, value); }

        public System.Int32? MinimumAge { get => _MinimumAge; set => SetProperty(ref _MinimumAge, value); }

        public System.String MinimumDuration  { get => _MinimumDuration; set => SetProperty(ref _MinimumDuration, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodTypeId"/> model
        /// </summary>
        public Guid? RefCredentialDefAssessMethodTypeId { get; set; }

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
        public void Load(ICredentialDefCriteria model)
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
