//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStaffViewModel
     /// </summary>
    public partial class AeStaffViewModel : ViewModelBase, Interfaces.IAeStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStaff";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAeStaffClassificationId property
        private Guid? _RefAeStaffClassificationId;

        // member variable for the RefAeStaffEmploymentStatusId property
        private Guid? _RefAeStaffEmploymentStatusId;

        // member variable for the YearsOfPriorAeTeachingExperience property
        private System.Decimal? _YearsOfPriorAeTeachingExperience;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AeStaffViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        public Guid? RefAeStaffClassificationId { get => _RefAeStaffClassificationId; set => SetProperty(ref _RefAeStaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get => _RefAeStaffEmploymentStatusId; set => SetProperty(ref _RefAeStaffEmploymentStatusId, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of adult education staff.
        /// </summary>
        public System.Decimal? YearsOfPriorAeTeachingExperience { get => _YearsOfPriorAeTeachingExperience; set => SetProperty(ref _YearsOfPriorAeTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAeStaffClassificationId = model.RefAeStaffClassificationId;
            RefAeStaffEmploymentStatusId = model.RefAeStaffEmploymentStatusId;
            YearsOfPriorAeTeachingExperience = model.YearsOfPriorAeTeachingExperience;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
