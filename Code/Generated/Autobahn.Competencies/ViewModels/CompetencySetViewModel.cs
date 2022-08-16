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

        // member variable for the CompletionCriteriaThreshold property
        private  _CompletionCriteriaThreshold;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCompletionCriteriaId property
        private Guid? _RefCompletionCriteriaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CompletionCriteriaThreshold { get => _CompletionCriteriaThreshold; set => SetProperty(ref _CompletionCriteriaThreshold, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

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
            CompletionCriteriaThreshold = model.CompletionCriteriaThreshold; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCompletionCriteriaId = model.RefCompletionCriteriaId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
