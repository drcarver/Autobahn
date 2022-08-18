//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleStatus View Model
     /// </summary>
    public partial class RoleStatusViewModel : ViewModelBase, Interfaces.IRoleStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleStatus";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefRoleStatusId -- (backing property for Enrollment Status)
        private Guid? _RefRoleStatusId;

        // StatusEndDate -- (backing property for Employment End Date)
        private System.DateTime? _StatusEndDate;

        // StatusStartDate -- (backing property for Employment Start Date)
        private System.DateTime _StatusStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Enrollment Status
        /// <para>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefRoleStatusId { get => _RefRoleStatusId; set => SetProperty(ref _RefRoleStatusId, value); }

        /// <summary>
        /// Employment End Date
        /// <para>
        /// The year, month and day on which a person ended self-employment or employment with an organization or institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19794">Employment End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// Employment Start Date
        /// <para>
        /// The year, month and day on which a person began self-employment or employment with an organization or institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19345">Employment Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefRoleStatusId = model.RefRoleStatusId; // Enrollment Status
            StatusEndDate = model.StatusEndDate; // Employment End Date
            StatusStartDate = model.StatusStartDate; // Employment Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
