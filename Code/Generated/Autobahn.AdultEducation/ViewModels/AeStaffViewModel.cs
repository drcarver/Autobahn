//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStaffViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the YearsOfPriorAeTeachingExperience property
        private System.Decimal? _YearsOfPriorAeTeachingExperience;

        // member variable for the RefAeStaffClassificationId property
        private Guid? _RefAeStaffClassificationId;

        // member variable for the RefAeStaffEmploymentStatusId property
        private Guid? _RefAeStaffEmploymentStatusId;

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
        /// The title of the AeStaffViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? YearsOfPriorAeTeachingExperience { get => _YearsOfPriorAeTeachingExperience; set => SetProperty(ref _YearsOfPriorAeTeachingExperience, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassificationId"/> model
        /// </summary>
        public Guid? RefAeStaffClassificationId { get => _RefAeStaffClassificationId; set => SetProperty(ref _RefAeStaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatusId"/> model
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get => _RefAeStaffEmploymentStatusId; set => SetProperty(ref _RefAeStaffEmploymentStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            YearsOfPriorAeTeachingExperience = model.YearsOfPriorAeTeachingExperience;
            RefAeStaffClassificationId = model.RefAeStaffClassificationId;
            RefAeStaffEmploymentStatusId = model.RefAeStaffEmploymentStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
