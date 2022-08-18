//**********************************************************
//* DomainName: Common Models
//* FileName:   ActivityViewModel.cs
//* Name:       Activity Description
//* Definition: A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
     /// </summary>
    public partial class ActivityViewModel : ViewModelBase, Interfaces.IActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Activity";

        // ActivityDescription -- (backing property for Activity Description)
        private System.String _ActivityDescription;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Activity Description
        /// <para>
        /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20505">Activity Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ActivityDescription { get => _ActivityDescription; set => SetProperty(ref _ActivityDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityDescription = model.ActivityDescription; // Activity Description
            OrganizationId = model.OrganizationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
