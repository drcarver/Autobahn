//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ApipInteractionViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ApipInteractionViewModel
     /// </summary>
    public partial class ApipInteractionViewModel : ViewModelBase, Interfaces.IApipInteractionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ApipInteraction";

        // member variable for the AssessmentItemApipId property
        private Guid _AssessmentItemApipId;

        // member variable for the Xml property
        private System.String _Xml;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

        // member variable for the APIPInteractionSequenceNumber property
        private System.Decimal? _APIPInteractionSequenceNumber;

        // member variable for the RefApipInteractionTypeId property
        private Guid? _RefApipInteractionTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ApipInteractionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemApipId"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get => _AssessmentItemApipId; set => SetProperty(ref _AssessmentItemApipId, value); }

        public System.String Xml  { get => _Xml; set => SetProperty(ref _Xml, value); }

        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        public System.Decimal? APIPInteractionSequenceNumber { get => _APIPInteractionSequenceNumber; set => SetProperty(ref _APIPInteractionSequenceNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionTypeId"/> model
        /// </summary>
        public Guid? RefApipInteractionTypeId { get => _RefApipInteractionTypeId; set => SetProperty(ref _RefApipInteractionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApipInteraction model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemApipId = model.AssessmentItemApipId;
            Xml = model.Xml;
            SequenceNumber = model.SequenceNumber;
            APIPInteractionSequenceNumber = model.APIPInteractionSequenceNumber;
            RefApipInteractionTypeId = model.RefApipInteractionTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
