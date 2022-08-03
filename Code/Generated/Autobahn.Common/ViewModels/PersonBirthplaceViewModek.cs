//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonBirthplaceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonBirthplaceViewModel
     /// </summary>
    public partial class PersonBirthplaceViewModel : BindableBase, IPersonBirthplace
    {
#region "Backing Fields"
        // member variable for the City property
        private System.String _City;

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

        public System.String City  { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateId"/> model
        /// </summary>
        public Guid? RefStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountryId"/> model
        /// </summary>
        public Guid? RefCountryId { get; set; }

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
        public void Load(IPersonBirthplace model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            City = model.City;
            RefStateId = model.RefStateId;
            RefCountryId = model.RefCountryId;
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
