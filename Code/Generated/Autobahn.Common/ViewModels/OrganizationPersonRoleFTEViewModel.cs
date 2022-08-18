//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFTEViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleFTE View Model
     /// </summary>
    public partial class OrganizationPersonRoleFTEViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleFTE
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleFTE";

        // FullTimeEquivalency -- (backing property for Full Time Equivalency)
        private System.Decimal _FullTimeEquivalency;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Full Time Equivalency
        /// <para>
        /// The time a person is enrolled, employed, involved, or participates in the organization, divided by the time the organization defines as full-time for that role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20906">Full Time Equivalency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleFTE model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency; // Full Time Equivalency
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
