//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramViewModel.cs
//* Name:       Credits Required
//* Definition: The total number of credits required for a student to graduate from the school of enrollment or complete a program.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
     /// </summary>
    public partial class ProgramViewModel : ViewModelBase, Interfaces.IProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Program";

        // CreditsRequired -- (backing property for Credits Required)
        private System.Decimal? _CreditsRequired;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credits Required
        /// <para>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20553">Credits Required</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditsRequired { get => _CreditsRequired; set => SetProperty(ref _CreditsRequired, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsRequired = model.CreditsRequired; // Credits Required
            OrganizationId = model.OrganizationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
