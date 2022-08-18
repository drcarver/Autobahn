//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceStaffViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceStaff View Model
     /// </summary>
    public partial class ServiceStaffViewModel : ViewModelBase, Interfaces.IServiceStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceStaff";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefSpecialEducationStaffCategoryId -- (backing property for Special Education Support Services Category)
        private Guid _RefSpecialEducationStaffCategoryId;

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
        /// Special Education Support Services Category
        /// <para>
        /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19549">Special Education Support Services Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefSpecialEducationStaffCategoryId { get => _RefSpecialEducationStaffCategoryId; set => SetProperty(ref _RefSpecialEducationStaffCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId; // Special Education Support Services Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
