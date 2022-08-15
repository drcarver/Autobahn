//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationServiceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationServiceViewModel
     /// </summary>
    public partial class OrganizationServiceViewModel : ViewModelBase, Interfaces.IOrganizationService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationService";

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Student Support Service Type")]
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationService model)
        {
            IsBusy = true;
            Id = model.Id;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // Student Support Service Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
