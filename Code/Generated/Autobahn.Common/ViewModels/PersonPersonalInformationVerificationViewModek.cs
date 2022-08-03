//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonPersonalInformationVerificationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonPersonalInformationVerificationViewModel
     /// </summary>
    public partial class PersonPersonalInformationVerificationViewModel : BindableBase, IPersonPersonalInformationVerification
    {
#region "Backing Fields"
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
        /// Reference to an optional instance of the <see cref="PersonAddressId"/> model
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDetailId"/> model
        /// </summary>
        public Guid? PersonDetailId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonTelephoneId"/> model
        /// </summary>
        public Guid? PersonTelephoneId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationTypeId"/> model
        /// </summary>
        public Guid? RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerificationId"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

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
        public void Load(IPersonPersonalInformationVerification model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            PersonAddressId = model.PersonAddressId;
            PersonDetailId = model.PersonDetailId;
            PersonTelephoneId = model.PersonTelephoneId;
            RefPersonalInformationTypeId = model.RefPersonalInformationTypeId;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId;
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
