//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestCompetencyDefinitionViewModel
     /// </summary>
    public partial class AssessmentSubtestCompetencyDefinitionViewModel : ViewModelBase, Interfaces.IAssessmentSubtestCompetencyDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtestCompetencyDefinition";

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestCompetencyDefinitionViewModel
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
        public void Load(Interfaces.IAssessmentSubtestCompetencyDefinition model)
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
