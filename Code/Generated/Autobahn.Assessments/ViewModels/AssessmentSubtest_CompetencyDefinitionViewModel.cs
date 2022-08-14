//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtest_CompetencyDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtest_CompetencyDefinitionViewModel
     /// </summary>
    public partial class AssessmentSubtest_CompetencyDefinitionViewModel : ViewModelBase, Interfaces.IAssessmentSubtest_CompetencyDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtest_CompetencyDefinition";

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtest_CompetencyDefinitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get => _CompetencyDefinitionId; set => SetProperty(ref _CompetencyDefinitionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest_CompetencyDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubtestId = model.AssessmentSubtestId;
            CompetencyDefinitionId = model.CompetencyDefinitionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
