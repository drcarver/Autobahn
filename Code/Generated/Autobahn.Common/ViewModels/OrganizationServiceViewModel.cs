//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationService View Model
     /// </summary>
    public partial class OrganizationServiceViewModel : ViewModelBase, Interfaces.IOrganizationService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationService";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefStudentSupportServiceTypeId -- (backing property for Student Support Service Type)
        private Guid _RefStudentSupportServiceTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Student Support Service Type
        /// <para>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationService model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // Student Support Service Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
