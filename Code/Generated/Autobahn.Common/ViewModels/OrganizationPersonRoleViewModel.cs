//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRole View Model
     /// </summary>
    public partial class OrganizationPersonRoleViewModel : ViewModelBase, Interfaces.IOrganizationPersonRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRole";

        // EntryDate -- (backing property for Activity Involvement Begin Date)
        private System.DateTime? _EntryDate;

        // ExitDate -- (backing property for Activity Involvement End Date)
        private System.DateTime? _ExitDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RoleId property
        private Guid _RoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Activity Involvement Begin Date
        /// <para>
        /// The year, month and day on which the person began to participate in the activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19007">Activity Involvement Begin Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EntryDate { get => _EntryDate; set => SetProperty(ref _EntryDate, value); }

        /// <summary>
        /// Activity Involvement End Date
        /// <para>
        /// The year, month and day on which the person ceased to participate in the activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19008">Activity Involvement End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ExitDate { get => _ExitDate; set => SetProperty(ref _ExitDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRole"/> model
        /// </summary>
        public Guid RoleId { get => _RoleId; set => SetProperty(ref _RoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRole model)
        {
            IsBusy = true;
            Id = model.Id;
            EntryDate = model.EntryDate; // Activity Involvement Begin Date
            ExitDate = model.ExitDate; // Activity Involvement End Date
            OrganizationId = model.OrganizationId; // 
            PersonId = model.PersonId; // 
            RoleId = model.RoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
