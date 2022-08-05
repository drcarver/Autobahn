//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12OrganizationStudentResponsibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefK12ResponsibilityTypeId property
        private Guid _RefK12ResponsibilityTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefStudentSchoolAffiliationStateDefinedStatusId property
        private Guid? _RefStudentSchoolAffiliationStateDefinedStatusId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12OrganizationStudentResponsibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12ResponsibilityTypeId"/> model
        /// </summary>
        public Guid RefK12ResponsibilityTypeId { get => _RefK12ResponsibilityTypeId; set => SetProperty(ref _RefK12ResponsibilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatusId"/> model
        /// </summary>
        public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get => _RefStudentSchoolAffiliationStateDefinedStatusId; set => SetProperty(ref _RefStudentSchoolAffiliationStateDefinedStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12OrganizationStudentResponsibility model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefK12ResponsibilityTypeId = model.RefK12ResponsibilityTypeId;
            RefStudentSchoolAffiliationStateDefinedStatusId = model.RefStudentSchoolAffiliationStateDefinedStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
