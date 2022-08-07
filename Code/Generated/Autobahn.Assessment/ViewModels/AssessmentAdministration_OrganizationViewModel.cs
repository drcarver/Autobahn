//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAdministration_OrganizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentAdministration_OrganizationViewModel
     /// </summary>
    public partial class AssessmentAdministration_OrganizationViewModel : ViewModelBase, Interfaces.IAssessmentAdministration_OrganizationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAdministration_Organization";

        // member variable for the AssessmentAdministrationId property
        private Guid _AssessmentAdministrationId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

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
        /// The title of the AssessmentAdministration_OrganizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministrationId"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAdministration_Organization model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            OrganizationId = model.OrganizationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
