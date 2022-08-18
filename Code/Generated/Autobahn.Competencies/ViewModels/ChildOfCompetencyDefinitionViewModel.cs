//**********************************************************
//* DomainName: Competencies
//* FileName:   ChildOfCompetencyDefinitionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The ChildOfCompetencyDefinition View Model
     /// </summary>
    public partial class ChildOfCompetencyDefinitionViewModel : ViewModelBase, Interfaces.IChildOfCompetencyDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ChildOfCompetencyDefinition";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IChildOfCompetencyDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
