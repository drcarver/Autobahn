//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the Criteria property
        private Guid? _Criteria;

        // member variable for the CriteriaUrl property
        private  _CriteriaUrl;

        // member variable for the EstimatedDuration property
        private  _EstimatedDuration;

        // member variable for the MaximumDuration property
        private  _MaximumDuration;

        // member variable for the MinimumAge property
        private  _MinimumAge;

        // member variable for the MinimumDuration property
        private  _MinimumDuration;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCredentialDefAssessMethodTypeId property
        private  _RefCredentialDefAssessMethodTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Criteria { get => _Criteria; set => SetProperty(ref _Criteria, value); }

        /// <summary>
        /// </summary>
        public  CriteriaUrl { get => _CriteriaUrl; set => SetProperty(ref _CriteriaUrl, value); }

        /// <summary>
        /// </summary>
        public  EstimatedDuration { get => _EstimatedDuration; set => SetProperty(ref _EstimatedDuration, value); }

        /// <summary>
        /// </summary>
        public  MaximumDuration { get => _MaximumDuration; set => SetProperty(ref _MaximumDuration, value); }

        /// <summary>
        /// </summary>
        public  MinimumAge { get => _MinimumAge; set => SetProperty(ref _MinimumAge, value); }

        /// <summary>
        /// </summary>
        public  MinimumDuration { get => _MinimumDuration; set => SetProperty(ref _MinimumDuration, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
        /// </summary>
        public  RefCredentialDefAssessMethodTypeId { get => _RefCredentialDefAssessMethodTypeId; set => SetProperty(ref _RefCredentialDefAssessMethodTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCriteria model)
        {
            IsBusy = true;
            Id = model.Id;
            Criteria = model.Criteria; // 
            CriteriaUrl = model.CriteriaUrl; // 
            EstimatedDuration = model.EstimatedDuration; // 
            MaximumDuration = model.MaximumDuration; // 
            MinimumAge = model.MinimumAge; // 
            MinimumDuration = model.MinimumDuration; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCredentialDefAssessMethodTypeId = model.RefCredentialDefAssessMethodTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
