//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IncidentViewModel
     /// </summary>
    public partial class IncidentViewModel : ViewModelBase, Interfaces.IIncident
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Incident";

        // member variable for the IncidentIdentifier property
        private System.String _IncidentIdentifier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IncidentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19492">Incident Identifier</a>
        /// </para>
        /// </summary>
        [DisplayName("Incident Identifier")]
        public System.String IncidentIdentifier { get => _IncidentIdentifier; set => SetProperty(ref _IncidentIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncident model)
        {
            IsBusy = true;
            Id = model.Id;
            IncidentIdentifier = model.IncidentIdentifier; // Incident Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
