//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   Assessment_AssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The Assessment_AssessmentAdministrationViewModel
     /// </summary>
    public partial class Assessment_AssessmentAdministrationViewModel : ViewModelBase, Interfaces.IAssessment_AssessmentAdministration
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Assessment_AssessmentAdministration";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the AssessmentAdministrationId property
        private Guid _AssessmentAdministrationId;

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
        /// The title of the Assessment_AssessmentAdministrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministrationId"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessment_AssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
