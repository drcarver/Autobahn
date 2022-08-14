//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySet_RubricCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySet_RubricCriterionViewModel
     /// </summary>
    public partial class CompetencySet_RubricCriterionViewModel : ViewModelBase, Interfaces.ICompetencySet_RubricCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySet_RubricCriterion";

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        // member variable for the RubricCriterionId property
        private Guid _RubricCriterionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencySet_RubricCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get => _RubricCriterionId; set => SetProperty(ref _RubricCriterionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySet_RubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
            RubricCriterionId = model.RubricCriterionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
