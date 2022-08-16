//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormAssessmentFormSectionViewModel
     /// </summary>
    public partial class AssessmentFormAssessmentFormSectionViewModel : ViewModelBase, Interfaces.IAssessmentFormAssessmentFormSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormAssessmentFormSection";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the SequenceNumber property
        private Guid? _SequenceNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormAssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            SequenceNumber = model.SequenceNumber; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
