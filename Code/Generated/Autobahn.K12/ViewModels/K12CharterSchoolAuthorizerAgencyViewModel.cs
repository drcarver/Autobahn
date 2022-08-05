//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolAuthorizerAgencyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgencyViewModel
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgencyViewModel : ViewModelBase, Interfaces.IK12CharterSchoolAuthorizerAgency
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12CharterSchoolAuthorizerAgency";

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the RefCharterSchoolAuthorizerTypeId property
        private Guid _RefCharterSchoolAuthorizerTypeId;

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
        /// The title of the K12CharterSchoolAuthorizerAgencyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCharterSchoolAuthorizerTypeId"/> model
        /// </summary>
        public Guid RefCharterSchoolAuthorizerTypeId { get => _RefCharterSchoolAuthorizerTypeId; set => SetProperty(ref _RefCharterSchoolAuthorizerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12CharterSchoolAuthorizerAgency model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefCharterSchoolAuthorizerTypeId = model.RefCharterSchoolAuthorizerTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}