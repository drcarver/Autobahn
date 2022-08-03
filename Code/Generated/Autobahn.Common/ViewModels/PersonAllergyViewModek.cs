//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAllergyViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAllergyViewModel
     /// </summary>
    public partial class PersonAllergyViewModel : BindableBase, IPersonAllergy
    {
#region "Backing Fields"
        // member variable for the ReactionDescription property
        private System.String _ReactionDescription;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAllergyTypeId"/> model
        /// </summary>
        public Guid RefAllergyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverityId"/> model
        /// </summary>
        public Guid? RefAllergySeverityId { get; set; }

        public System.String ReactionDescription  { get => _ReactionDescription; set => SetProperty(ref _ReactionDescription, value); }

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
        public void Load(IPersonAllergy model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefAllergyTypeId = model.RefAllergyTypeId;
            RefAllergySeverityId = model.RefAllergySeverityId;
            ReactionDescription = model.ReactionDescription;
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
