//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTechnicalAssistanceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTechnicalAssistanceViewModel
     /// </summary>
    public partial class OrganizationTechnicalAssistanceViewModel : ViewModelBase, Interfaces.IOrganizationTechnicalAssistance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTechnicalAssistance";

        // member variable for the TechnicalAssistanceApprovedInd property
        private System.Boolean? _TechnicalAssistanceApprovedInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationTechnicalAssistanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Technical Assistance Approved Indicator")]
        public System.Boolean? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd; // Technical Assistance Approved Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
