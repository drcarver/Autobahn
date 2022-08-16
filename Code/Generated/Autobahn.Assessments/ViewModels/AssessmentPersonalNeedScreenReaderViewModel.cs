//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReaderViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedScreenReader
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedScreenReader";

        // member variable for the Pitch property
        private  _Pitch;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedLinkIndicationTypeId property
        private  _RefAssessmentNeedLinkIndicationTypeId;

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        // member variable for the SpeechRate property
        private  _SpeechRate;

        // member variable for the Volume property
        private  _Volume;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Pitch { get => _Pitch; set => SetProperty(ref _Pitch, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedLinkIndicationType"/> model
        /// </summary>
        public  RefAssessmentNeedLinkIndicationTypeId { get => _RefAssessmentNeedLinkIndicationTypeId; set => SetProperty(ref _RefAssessmentNeedLinkIndicationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get => _RefAssessmentNeedUsageTypeId; set => SetProperty(ref _RefAssessmentNeedUsageTypeId, value); }

        /// <summary>
        /// </summary>
        public  SpeechRate { get => _SpeechRate; set => SetProperty(ref _SpeechRate, value); }

        /// <summary>
        /// </summary>
        public  Volume { get => _Volume; set => SetProperty(ref _Volume, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedScreenReader model)
        {
            IsBusy = true;
            Id = model.Id;
            Pitch = model.Pitch; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedLinkIndicationTypeId = model.RefAssessmentNeedLinkIndicationTypeId; // 
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId; // 
            SpeechRate = model.SpeechRate; // 
            Volume = model.Volume; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
