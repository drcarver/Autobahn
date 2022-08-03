//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessViewModel
     /// </summary>
    public partial class PersonDigitalAccessViewModel : BindableBase, IPersonDigitalAccess
    {
#region "Backing Fields"
        // member variable for the InternetAccessInResidence property
        private System.Boolean? _InternetAccessInResidence;

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

        public System.Boolean? InternetAccessInResidence { get => _InternetAccessInResidence; set => SetProperty(ref _InternetAccessInResidence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddressId"/> model
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToInternetAccessInResidenceId"/> model
        /// </summary>
        public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessTypeInResidenceId"/> model
        /// </summary>
        public Guid? RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetPerformanceInResidenceId"/> model
        /// </summary>
        public Guid? RefInternetPerformanceInResidenceId { get; set; }

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
        public void Load(IPersonDigitalAccess model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            InternetAccessInResidence = model.InternetAccessInResidence;
            PersonAddressId = model.PersonAddressId;
            RefBarrierToInternetAccessInResidenceId = model.RefBarrierToInternetAccessInResidenceId;
            RefInternetAccessTypeInResidenceId = model.RefInternetAccessTypeInResidenceId;
            RefInternetPerformanceInResidenceId = model.RefInternetPerformanceInResidenceId;
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
