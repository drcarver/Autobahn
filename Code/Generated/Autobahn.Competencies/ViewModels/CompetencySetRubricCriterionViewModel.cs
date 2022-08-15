//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySetRubricCriterionViewModel
     /// </summary>
    public partial class CompetencySetRubricCriterionViewModel : ViewModelBase, Interfaces.ICompetencySetRubricCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySetRubricCriterion";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencySetRubricCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySetRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
