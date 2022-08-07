//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicHonorViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentAcademicHonorViewModel
     /// </summary>
    public partial class K12StudentAcademicHonorViewModel : ViewModelBase, Interfaces.IK12StudentAcademicHonorViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentAcademicHonor";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAcademicHonorTypeId property
        private Guid? _RefAcademicHonorTypeId;

        // member variable for the HonorDescription property
        private System.String _HonorDescription;

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
        /// The title of the K12StudentAcademicHonorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorTypeId"/> model
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get => _RefAcademicHonorTypeId; set => SetProperty(ref _RefAcademicHonorTypeId, value); }

        public System.String HonorDescription  { get => _HonorDescription; set => SetProperty(ref _HonorDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicHonor model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAcademicHonorTypeId = model.RefAcademicHonorTypeId;
            HonorDescription = model.HonorDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
