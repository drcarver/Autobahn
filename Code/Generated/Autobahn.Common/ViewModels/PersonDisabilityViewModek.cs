//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDisabilityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDisabilityViewModel
     /// </summary>
    public partial class PersonDisabilityViewModel : BindableBase, IPersonDisability
    {
#region "Backing Fields"
        // member variable for the DisabilityStatus property
        private System.Boolean? _DisabilityStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the SignificantCognitiveDisabilityIndicator property
        private System.Boolean? _SignificantCognitiveDisabilityIndicator;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityTypeId"/> model
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get; set; }

        public System.Boolean? DisabilityStatus { get => _DisabilityStatus; set => SetProperty(ref _DisabilityStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededTypeId"/> model
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionTypeId"/> model
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceTypeId"/> model
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCodeId"/> model
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Boolean? SignificantCognitiveDisabilityIndicator { get => _SignificantCognitiveDisabilityIndicator; set => SetProperty(ref _SignificantCognitiveDisabilityIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityTypeId"/> model
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get; set; }

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
        public void Load(IPersonDisability model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId;
            DisabilityStatus = model.DisabilityStatus;
            RefAccommodationsNeededTypeId = model.RefAccommodationsNeededTypeId;
            RefDisabilityConditionTypeId = model.RefDisabilityConditionTypeId;
            RefDisabilityDeterminationSourceTypeId = model.RefDisabilityDeterminationSourceTypeId;
            RefDisabilityConditionStatusCodeId = model.RefDisabilityConditionStatusCodeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            SignificantCognitiveDisabilityIndicator = model.SignificantCognitiveDisabilityIndicator;
            RefIDEADisabilityTypeId = model.RefIDEADisabilityTypeId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
