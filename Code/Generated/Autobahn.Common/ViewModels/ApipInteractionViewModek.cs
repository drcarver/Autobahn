//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ApipInteractionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ApipInteractionViewModel
     /// </summary>
    public partial class ApipInteractionViewModel : BindableBase, IApipInteraction
    {
#region "Backing Fields"
        // member variable for the Xml property
        private System.String _Xml;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

        // member variable for the APIPInteractionSequenceNumber property
        private System.Decimal? _APIPInteractionSequenceNumber;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemApipId"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get; set; }

        public System.String Xml  { get => _Xml; set => SetProperty(ref _Xml, value); }

        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        public System.Decimal? APIPInteractionSequenceNumber { get => _APIPInteractionSequenceNumber; set => SetProperty(ref _APIPInteractionSequenceNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionTypeId"/> model
        /// </summary>
        public Guid? RefApipInteractionTypeId { get; set; }

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
        public void Load(IApipInteraction model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemApipId = model.AssessmentItemApipId;
            Xml = model.Xml;
            SequenceNumber = model.SequenceNumber;
            APIPInteractionSequenceNumber = model.APIPInteractionSequenceNumber;
            RefApipInteractionTypeId = model.RefApipInteractionTypeId;
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
