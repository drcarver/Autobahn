//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentAcademicHonorViewModel
     /// </summary>
    public partial class K12StudentAcademicHonorViewModel : ViewModelBase, Interfaces.IK12StudentAcademicHonor
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentAcademicHonor";

        // member variable for the HonorDescription property
        private System.String _HonorDescription;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAcademicHonorTypeId property
        private Guid? _RefAcademicHonorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentAcademicHonorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </summary>
        public System.String HonorDescription { get => _HonorDescription; set => SetProperty(ref _HonorDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get => _RefAcademicHonorTypeId; set => SetProperty(ref _RefAcademicHonorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicHonor model)
        {
            IsBusy = true;
            Id = model.Id;
            HonorDescription = model.HonorDescription;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAcademicHonorTypeId = model.RefAcademicHonorTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
