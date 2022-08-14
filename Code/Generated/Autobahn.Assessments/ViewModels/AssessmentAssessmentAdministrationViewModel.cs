//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAssessmentAdministrationViewModel
     /// </summary>
    public partial class AssessmentAssessmentAdministrationViewModel : ViewModelBase, Interfaces.IAssessmentAssessmentAdministration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAssessmentAdministration";

        // member variable for the AssessmentAdministrationId property
        private Guid _AssessmentAdministrationId;

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAssessmentAdministrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            AssessmentId = model.AssessmentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
