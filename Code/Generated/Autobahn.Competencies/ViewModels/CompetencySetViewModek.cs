//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySetViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySetViewModel
     /// </summary>
    public partial class CompetencySetViewModel : BindableBase, ICompetencySet
    {
#region "Backing Fields"
        // member variable for the ChildOf_CompetencySet property
        private System.Int32? _ChildOf_CompetencySet;

        // member variable for the CompletionCriteriaThreshold property
        private System.Int32? _CompletionCriteriaThreshold;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.Int32? ChildOf_CompetencySet { get => _ChildOf_CompetencySet; set => SetProperty(ref _ChildOf_CompetencySet, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompletionCriteriaId"/> model
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

        public System.Int32? CompletionCriteriaThreshold { get => _CompletionCriteriaThreshold; set => SetProperty(ref _CompletionCriteriaThreshold, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(ICompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildOf_CompetencySet = model.ChildOf_CompetencySet;
            RefCompletionCriteriaId = model.RefCompletionCriteriaId;
            CompletionCriteriaThreshold = model.CompletionCriteriaThreshold;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
