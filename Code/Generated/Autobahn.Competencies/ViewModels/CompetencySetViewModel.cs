//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the ChildOfCompetencySet property
        private System.Int32? _ChildOfCompetencySet;

        // member variable for the CompletionCriteriaThreshold property
        private System.Int32? _CompletionCriteriaThreshold;

        // member variable for the RefCompletionCriteriaId property
        private Guid? _RefCompletionCriteriaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencySetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </summary>
        public System.Int32? ChildOfCompetencySet { get => _ChildOfCompetencySet; set => SetProperty(ref _ChildOfCompetencySet, value); }

        /// <summary>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </summary>
        public System.Int32? CompletionCriteriaThreshold { get => _CompletionCriteriaThreshold; set => SetProperty(ref _CompletionCriteriaThreshold, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteria"/> model
        /// </summary>
        public Guid? RefCompletionCriteriaId { get => _RefCompletionCriteriaId; set => SetProperty(ref _RefCompletionCriteriaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildOfCompetencySet = model.ChildOfCompetencySet;
            CompletionCriteriaThreshold = model.CompletionCriteriaThreshold;
            RefCompletionCriteriaId = model.RefCompletionCriteriaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
