//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySetRubricCriterion View Model
     /// </summary>
    public partial class CompetencySetRubricCriterionViewModel : ViewModelBase, Interfaces.ICompetencySetRubricCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySetRubricCriterion";

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        // member variable for the RubricCriterionId property
        private Guid _RubricCriterionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get => _RubricCriterionId; set => SetProperty(ref _RubricCriterionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySetRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId; // 
            RubricCriterionId = model.RubricCriterionId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
