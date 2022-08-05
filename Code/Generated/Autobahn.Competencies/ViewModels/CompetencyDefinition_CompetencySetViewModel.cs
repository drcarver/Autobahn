//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefinition_CompetencySetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefinition_CompetencySetViewModel
     /// </summary>
    public partial class CompetencyDefinition_CompetencySetViewModel : ViewModelBase, Interfaces.ICompetencyDefinition_CompetencySet
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefinition_CompetencySet";

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

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
        /// The title of the CompetencyDefinition_CompetencySetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinitionId"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get => _CompetencyDefinitionId; set => SetProperty(ref _CompetencyDefinitionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinition_CompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
            CompetencyDefinitionId = model.CompetencyDefinitionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
