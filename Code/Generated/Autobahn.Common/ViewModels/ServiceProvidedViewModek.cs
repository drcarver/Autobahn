//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProvidedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceProvidedViewModel
     /// </summary>
    public partial class ServiceProvidedViewModel : BindableBase, IServiceProvided
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceivedId"/> model
        /// </summary>
        public Guid ServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServicesId"/> model
        /// </summary>
        public Guid? RefServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceTypeId"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

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
        public void Load(IServiceProvided model)
        {
            IsBusy = true;
            Id = model.Id;
            ServicesReceivedId = model.ServicesReceivedId;
            RefServicesId = model.RefServicesId;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
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
