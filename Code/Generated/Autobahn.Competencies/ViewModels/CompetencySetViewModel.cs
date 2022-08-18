//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySet View Model
     /// </summary>
    public partial class CompetencySetViewModel : ViewModelBase, Interfaces.ICompetencySet
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySet";

        // member variable for the ChildOfCompetencySet property
        private System.Int32? _ChildOfCompetencySet;

        // CompletionCriteriaThreshold -- (backing property for Competency Set Completion Criteria Threshold)
        private System.Int32? _CompletionCriteriaThreshold;

        // RefCompletionCriteriaId -- (backing property for Competency Set Completion Criteria)
        private Guid? _RefCompletionCriteriaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.Int32? ChildOfCompetencySet { get => _ChildOfCompetencySet; set => SetProperty(ref _ChildOfCompetencySet, value); }

        /// <summary>
        /// Competency Set Completion Criteria Threshold
        /// <para>
        /// The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19878">Competency Set Completion Criteria Threshold</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? CompletionCriteriaThreshold { get => _CompletionCriteriaThreshold; set => SetProperty(ref _CompletionCriteriaThreshold, value); }

        /// <summary>
        /// Competency Set Completion Criteria
        /// <para>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19877">Competency Set Completion Criteria</a>
        /// </para>
        /// </summary>
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
            ChildOfCompetencySet = model.ChildOfCompetencySet; // 
            CompletionCriteriaThreshold = model.CompletionCriteriaThreshold; // Competency Set Completion Criteria Threshold
            RefCompletionCriteriaId = model.RefCompletionCriteriaId; // Competency Set Completion Criteria
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefCompletionCriteria List
        /// <summary>
        /// The complete <see cref="RefCompletionCriteria"> List
        /// </summary>
        private static List<ReferenceModelBase> RefCompletionCriteriaList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
