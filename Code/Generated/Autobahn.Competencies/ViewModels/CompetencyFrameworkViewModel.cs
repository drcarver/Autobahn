//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyFrameworkViewModel
     /// </summary>
    public partial class CompetencyFrameworkViewModel : ViewModelBase, Interfaces.ICompetencyFramework
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyFramework";

        // member variable for the URI property
        private System.String _URI;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyFrameworkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19670">Competency Framework Identifier URI</a>
        /// </para>
        /// </summary>
        [DisplayName("Competency Framework Identifier URI")]
        public System.String URI { get => _URI; set => SetProperty(ref _URI, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyFramework model)
        {
            IsBusy = true;
            Id = model.Id;
            URI = model.URI; // Competency Framework Identifier URI
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
