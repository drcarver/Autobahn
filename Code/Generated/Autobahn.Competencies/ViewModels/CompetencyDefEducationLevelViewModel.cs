//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefEducationLevel View Model
     /// </summary>
    public partial class CompetencyDefEducationLevelViewModel : ViewModelBase, Interfaces.ICompetencyDefEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefEducationLevel";

        // member variable for the CompetencyDefinitionId property
        private Guid _CompetencyDefinitionId;

        // RefEducationLevelId -- (backing property for Competency Definition Education Level)
        private Guid _RefEducationLevelId;

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
        /// Competency Definition Education Level
        /// <para>
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19701">Competency Definition Education Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefEducationLevelId { get => _RefEducationLevelId; set => SetProperty(ref _RefEducationLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyDefinitionId = model.CompetencyDefinitionId; // 
            RefEducationLevelId = model.RefEducationLevelId; // Competency Definition Education Level
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
