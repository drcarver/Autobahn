//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthBirthViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthBirthViewModel
     /// </summary>
    public partial class PersonHealthBirthViewModel : BindableBase, IPersonHealthBirth
    {
#region "Backing Fields"
        // member variable for the WeeksOfGestation property
        private System.Int32? _WeeksOfGestation;

        // member variable for the MultipleBirthIndicator property
        private System.Boolean? _MultipleBirthIndicator;

        // member variable for the WeightAtBirth property
        private System.String _WeightAtBirth;

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

        public System.Int32? WeeksOfGestation { get => _WeeksOfGestation; set => SetProperty(ref _WeeksOfGestation, value); }

        public System.Boolean? MultipleBirthIndicator { get => _MultipleBirthIndicator; set => SetProperty(ref _MultipleBirthIndicator, value); }

        public System.String WeightAtBirth  { get => _WeightAtBirth; set => SetProperty(ref _WeightAtBirth, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBeganId"/> model
        /// </summary>
        public Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

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
        public void Load(IPersonHealthBirth model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            WeeksOfGestation = model.WeeksOfGestation;
            MultipleBirthIndicator = model.MultipleBirthIndicator;
            WeightAtBirth = model.WeightAtBirth;
            RefTrimesterWhenPrenatalCareBeganId = model.RefTrimesterWhenPrenatalCareBeganId;
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
