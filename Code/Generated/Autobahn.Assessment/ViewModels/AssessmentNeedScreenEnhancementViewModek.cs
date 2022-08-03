//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedScreenEnhancementViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancementViewModel
     /// </summary>
    public partial class AssessmentNeedScreenEnhancementViewModel : BindableBase, IAssessmentNeedScreenEnhancement
    {
#region "Backing Fields"
        // member variable for the InvertColorChoice property
        private System.Boolean? _InvertColorChoice;

        // member variable for the Magnification property
        private System.Decimal? _Magnification;

        // member variable for the ForegroundColor property
        private System.String _ForegroundColor;

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

        public System.Boolean? InvertColorChoice { get => _InvertColorChoice; set => SetProperty(ref _InvertColorChoice, value); }

        public System.Decimal? Magnification { get => _Magnification; set => SetProperty(ref _Magnification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileScreenEnhancementId"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        public System.String ForegroundColor  { get => _ForegroundColor; set => SetProperty(ref _ForegroundColor, value); }

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
        public void Load(IAssessmentNeedScreenEnhancement model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            InvertColorChoice = model.InvertColorChoice;
            Magnification = model.Magnification;
            AssessmentPersonalNeedsProfileScreenEnhancementId = model.AssessmentPersonalNeedsProfileScreenEnhancementId;
            ForegroundColor = model.ForegroundColor;
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
