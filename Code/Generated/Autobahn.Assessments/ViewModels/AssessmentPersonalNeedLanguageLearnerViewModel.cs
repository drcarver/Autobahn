//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedLanguageLearner";

        // member variable for the ActivateByDefault property
        private  _ActivateByDefault;

        // member variable for the AssignedSupport property
        private Guid? _AssignedSupport;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedsProfileContentLanguageLearnerTypeId property
        private  _RefAssessmentNeedsProfileContentLanguageLearnerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

        /// <summary>
        /// </summary>
        public Guid? AssignedSupport { get => _AssignedSupport; set => SetProperty(ref _AssignedSupport, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedsProfileContentLanguageLearnerType"/> model
        /// </summary>
        public  RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get => _RefAssessmentNeedsProfileContentLanguageLearnerTypeId; set => SetProperty(ref _RefAssessmentNeedsProfileContentLanguageLearnerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedLanguageLearner model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivateByDefault = model.ActivateByDefault; // 
            AssignedSupport = model.AssignedSupport; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedsProfileContentLanguageLearnerTypeId = model.RefAssessmentNeedsProfileContentLanguageLearnerTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
