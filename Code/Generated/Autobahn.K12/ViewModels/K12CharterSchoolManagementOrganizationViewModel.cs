//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolManagementOrganizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CharterSchoolManagementOrganizationViewModel
     /// </summary>
    public partial class K12CharterSchoolManagementOrganizationViewModel : ViewModelBase, Interfaces.IK12CharterSchoolManagementOrganizationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12CharterSchoolManagementOrganization";

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the RefCharterSchoolManagementOrganizationTypeId property
        private Guid? _RefCharterSchoolManagementOrganizationTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12CharterSchoolManagementOrganizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationTypeId"/> model
        /// </summary>
        public Guid? RefCharterSchoolManagementOrganizationTypeId { get => _RefCharterSchoolManagementOrganizationTypeId; set => SetProperty(ref _RefCharterSchoolManagementOrganizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12CharterSchoolManagementOrganization model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefCharterSchoolManagementOrganizationTypeId = model.RefCharterSchoolManagementOrganizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
