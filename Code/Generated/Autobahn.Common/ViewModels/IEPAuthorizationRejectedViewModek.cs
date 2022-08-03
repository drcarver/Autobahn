//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorizationRejectedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationRejectedViewModel
     /// </summary>
    public partial class IEPAuthorizationRejectedViewModel : BindableBase, IIEPAuthorizationRejected
    {
#region "Backing Fields"
        // member variable for the PortionDescription property
        private System.String _PortionDescription;

        // member variable for the PortionExplanation property
        private System.String _PortionExplanation;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="IEPAuthorizationId"/> model
        /// </summary>
        public Guid IEPAuthorizationId { get; set; }

        public System.String PortionDescription  { get => _PortionDescription; set => SetProperty(ref _PortionDescription, value); }

        public System.String PortionExplanation  { get => _PortionExplanation; set => SetProperty(ref _PortionExplanation, value); }

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
        public void Load(IIEPAuthorizationRejected model)
        {
            IsBusy = true;
            Id = model.Id;
            IEPAuthorizationId = model.IEPAuthorizationId;
            PortionDescription = model.PortionDescription;
            PortionExplanation = model.PortionExplanation;
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
