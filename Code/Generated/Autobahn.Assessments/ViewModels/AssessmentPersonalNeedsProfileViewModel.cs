//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfile";

        // member variable for the ActivateByDefault property
        private  _ActivateByDefault;

        // member variable for the AssessmentNeedType property
        private  _AssessmentNeedType;

        // member variable for the AssignedSupportFlag property
        private Guid? _AssignedSupportFlag;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

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
        public  AssessmentNeedType { get => _AssessmentNeedType; set => SetProperty(ref _AssessmentNeedType, value); }

        /// <summary>
        /// </summary>
        public Guid? AssignedSupportFlag { get => _AssignedSupportFlag; set => SetProperty(ref _AssignedSupportFlag, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivateByDefault = model.ActivateByDefault; // 
            AssessmentNeedType = model.AssessmentNeedType; // 
            AssignedSupportFlag = model.AssignedSupportFlag; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
