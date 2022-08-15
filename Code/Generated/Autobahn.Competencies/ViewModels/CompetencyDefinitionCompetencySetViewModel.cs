//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySetViewModel
     /// </summary>
    public partial class CompetencyDefinitionCompetencySetViewModel : ViewModelBase, Interfaces.ICompetencyDefinitionCompetencySet
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefinitionCompetencySet";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyDefinitionCompetencySetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinitionCompetencySet model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
