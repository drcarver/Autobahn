//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_RubricViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySet_RubricViewModel
     /// </summary>
    public partial class CompetencySet_RubricViewModel : ViewModelBase, Interfaces.ICompetencySet_RubricViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencySet_Rubric";

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        // member variable for the RubricId property
        private Guid _RubricId;

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
        /// The title of the CompetencySet_RubricViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricId"/> model
        /// </summary>
        public Guid RubricId { get => _RubricId; set => SetProperty(ref _RubricId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencySet_Rubric model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
            RubricId = model.RubricId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
