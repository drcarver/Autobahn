//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestCompetencyDefinitionViewModel
     /// </summary>
    public partial class AssessmentSubtestCompetencyDefinitionViewModel : ViewModelBase, Interfaces.IAssessmentSubtestCompetencyDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtestCompetencyDefinition";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestCompetencyDefinitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtestCompetencyDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
