//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAllergyViewModel
     /// </summary>
    public partial class PersonAllergyViewModel : ViewModelBase, Interfaces.IPersonAllergy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAllergy";

        // member variable for the ReactionDescription property
        private Guid? _ReactionDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAllergySeverityId property
        private  _RefAllergySeverityId;

        // member variable for the RefAllergyTypeId property
        private  _RefAllergyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ReactionDescription { get => _ReactionDescription; set => SetProperty(ref _ReactionDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverity"/> model
        /// </summary>
        public  RefAllergySeverityId { get => _RefAllergySeverityId; set => SetProperty(ref _RefAllergySeverityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergyType"/> model
        /// </summary>
        public  RefAllergyTypeId { get => _RefAllergyTypeId; set => SetProperty(ref _RefAllergyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAllergy model)
        {
            IsBusy = true;
            Id = model.Id;
            ReactionDescription = model.ReactionDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAllergySeverityId = model.RefAllergySeverityId; // 
            RefAllergyTypeId = model.RefAllergyTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
