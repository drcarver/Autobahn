//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySet View Model
     /// </summary>
    public partial class CompetencyDefinitionCompetencySetViewModel : ViewModelBase, Interfaces.ICompetencyDefinitionCompetencySet
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefinitionCompetencySet";

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        // member variable for the CompetencySetId property
        private Guid _CompetencySetId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get => _CompetencyDefinitionId; set => SetProperty(ref _CompetencyDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinitionCompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyDefinitionId = model.CompetencyDefinitionId; // 
            CompetencySetId = model.CompetencySetId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
