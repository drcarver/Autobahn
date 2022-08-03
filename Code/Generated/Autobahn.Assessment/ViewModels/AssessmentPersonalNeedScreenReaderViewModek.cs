//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedScreenReaderViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReaderViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderViewModel : BindableBase, IAssessmentPersonalNeedScreenReader
    {
#region "Backing Fields"
        // member variable for the SpeechRate property
        private System.Int32? _SpeechRate;

        // member variable for the Pitch property
        private System.Decimal? _Pitch;

        // member variable for the Volume property
        private System.Decimal? _Volume;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        public System.Int32? SpeechRate { get => _SpeechRate; set => SetProperty(ref _SpeechRate, value); }

        public System.Decimal? Pitch { get => _Pitch; set => SetProperty(ref _Pitch, value); }

        public System.Decimal? Volume { get => _Volume; set => SetProperty(ref _Volume, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedLinkIndicationTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

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
        public void Load(IAssessmentPersonalNeedScreenReader model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId;
            SpeechRate = model.SpeechRate;
            Pitch = model.Pitch;
            Volume = model.Volume;
            RefAssessmentNeedLinkIndicationTypeId = model.RefAssessmentNeedLinkIndicationTypeId;
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
