//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonImmunizationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonImmunizationViewModel
     /// </summary>
    public partial class PersonImmunizationViewModel : BindableBase, IPersonImmunization
    {
#region "Backing Fields"
        // member variable for the ImmunizationDate property
        private System.DateTime _ImmunizationDate;

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

        public System.DateTime ImmunizationDate  { get => _ImmunizationDate; set => SetProperty(ref _ImmunizationDate, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationTypeId"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get; set; }

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
        public void Load(IPersonImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            ImmunizationDate = model.ImmunizationDate;
            RefImmunizationTypeId = model.RefImmunizationTypeId;
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
