//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationAccreditationViewModel
     /// </summary>
    public partial class OrganizationAccreditationViewModel : ViewModelBase, Interfaces.IOrganizationAccreditation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationAccreditation";

        // member variable for the RefHigherEducationInstitutionAccreditationStatusId property
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationAccreditationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Higher Education Institution Accreditation Status")]
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationAccreditation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // Higher Education Institution Accreditation Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
