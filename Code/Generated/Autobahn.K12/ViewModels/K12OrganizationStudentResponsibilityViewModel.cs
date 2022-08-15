//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12OrganizationStudentResponsibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12OrganizationStudentResponsibilityViewModel
     /// </summary>
    public partial class K12OrganizationStudentResponsibilityViewModel : ViewModelBase, Interfaces.IK12OrganizationStudentResponsibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12OrganizationStudentResponsibility";

        // member variable for the RefK12ResponsibilityTypeId property
        private Guid _RefK12ResponsibilityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12OrganizationStudentResponsibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12ResponsibilityType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19587">Responsible District Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Responsible District Type")]
        public Guid RefK12ResponsibilityTypeId { get => _RefK12ResponsibilityTypeId; set => SetProperty(ref _RefK12ResponsibilityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12OrganizationStudentResponsibility model)
        {
            IsBusy = true;
            Id = model.Id;
            RefK12ResponsibilityTypeId = model.RefK12ResponsibilityTypeId; // Responsible District Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
