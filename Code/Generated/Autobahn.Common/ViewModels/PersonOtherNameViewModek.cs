//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonOtherNameViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonOtherNameViewModel
     /// </summary>
    public partial class PersonOtherNameViewModel : BindableBase, IPersonOtherName
    {
#region "Backing Fields"
        // member variable for the OtherName property
        private System.String _OtherName;

        // member variable for the FirstName property
        private System.String _FirstName;

        // member variable for the MiddleName property
        private System.String _MiddleName;

        // member variable for the LastName property
        private System.String _LastName;

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
        /// Reference to an optional instance of the <see cref="RefOtherNameTypeId"/> model
        /// </summary>
        public Guid? RefOtherNameTypeId { get; set; }

        public System.String OtherName  { get => _OtherName; set => SetProperty(ref _OtherName, value); }

        public System.String FirstName  { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        public System.String MiddleName  { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        public System.String LastName  { get => _LastName; set => SetProperty(ref _LastName, value); }

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
        public void Load(IPersonOtherName model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefOtherNameTypeId = model.RefOtherNameTypeId;
            OtherName = model.OtherName;
            FirstName = model.FirstName;
            MiddleName = model.MiddleName;
            LastName = model.LastName;
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
