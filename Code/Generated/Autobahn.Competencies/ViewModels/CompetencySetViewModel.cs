//**********************************************************
//* DomainName: Autobahn.Competencies
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

        // member variable for the ChildOf_CompetencySet property
        private System.Int32? _ChildOf_CompetencySet;

        // member variable for the RefCompletionCriteriaId property
        private Guid? _RefCompletionCriteriaId;

        // member variable for the CompletionCriteriaThreshold property
        private System.Int32? _CompletionCriteriaThreshold;

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
        /// The title of the CompetencySetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.Int32? ChildOf_CompetencySet { get => _ChildOf_CompetencySet; set => SetProperty(ref _ChildOf_CompetencySet, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteriaId"/> model
        /// </summary>
        public Guid? RefCompletionCriteriaId { get => _RefCompletionCriteriaId; set => SetProperty(ref _RefCompletionCriteriaId, value); }

        public System.Int32? CompletionCriteriaThreshold { get => _CompletionCriteriaThreshold; set => SetProperty(ref _CompletionCriteriaThreshold, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildOf_CompetencySet = model.ChildOf_CompetencySet;
            RefCompletionCriteriaId = model.RefCompletionCriteriaId;
            CompletionCriteriaThreshold = model.CompletionCriteriaThreshold;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
