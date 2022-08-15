//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySetViewModel
     /// </summary>
    public partial class CompetencySetViewModel : ViewModelBase, Interfaces.ICompetencySet
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySet";

        // member variable for the RefCompletionCriteriaId property
        private Guid? _RefCompletionCriteriaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencySetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteria"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19877">Competency Set Completion Criteria</a>
        /// </para>
        /// </summary>
        [DisplayName("Competency Set Completion Criteria")]
        public Guid? RefCompletionCriteriaId { get => _RefCompletionCriteriaId; set => SetProperty(ref _RefCompletionCriteriaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCompletionCriteriaId = model.RefCompletionCriteriaId; // Competency Set Completion Criteria
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
