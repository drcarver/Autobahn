//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencyDefinition_CompetencySetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The CompetencyDefinition_CompetencySetViewModel
     /// </summary>
    public partial class CompetencyDefinition_CompetencySetViewModel : ViewModelBase, Interfaces.ICompetencyDefinition_CompetencySet
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefinition_CompetencySet";

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyDefinition_CompetencySetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get => _CompetencyDefinitionId; set => SetProperty(ref _CompetencyDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinition_CompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyDefinitionId = model.CompetencyDefinitionId;
            CompetencySetId = model.CompetencySetId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
