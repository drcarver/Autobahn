//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_RubricCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySet_RubricCriterionViewModel
     /// </summary>
    public partial class CompetencySet_RubricCriterionViewModel : ViewModelBase, Interfaces.ICompetencySet_RubricCriterionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySet_RubricCriterion";

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        // member variable for the RubricCriterionId property
        private Guid _RubricCriterionId;

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
        /// The title of the CompetencySet_RubricCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionId"/> model
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
