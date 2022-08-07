//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELEnrollmentViewModel
     /// </summary>
    public partial class ELEnrollmentViewModel : ViewModelBase, Interfaces.IELEnrollmentViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELEnrollment";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the EnrollmentDate property
        private System.DateTime? _EnrollmentDate;

        // member variable for the NumberOfDaysInAttendance property
        private System.Decimal? _NumberOfDaysInAttendance;

        // member variable for the ELClassSectionId property
        private Guid? _ELClassSectionId;

        // member variable for the RefIDEAEnvironmentELId property
        private Guid? _RefIDEAEnvironmentELId;

        // member variable for the RefFoodServiceParticipationId property
        private Guid? _RefFoodServiceParticipationId;

        // member variable for the RefServiceOptionId property
        private Guid? _RefServiceOptionId;

        // member variable for the RefELFederalFundingTypeId property
        private Guid? _RefELFederalFundingTypeId;

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
        /// The title of the ELEnrollmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.DateTime? EnrollmentDate { get => _EnrollmentDate; set => SetProperty(ref _EnrollmentDate, value); }

        public System.Decimal? NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELClassSectionId"/> model
        /// </summary>
        public Guid? ELClassSectionId { get => _ELClassSectionId; set => SetProperty(ref _ELClassSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEnvironmentELId"/> model
        /// </summary>
        public Guid? RefIDEAEnvironmentELId { get => _RefIDEAEnvironmentELId; set => SetProperty(ref _RefIDEAEnvironmentELId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceParticipationId"/> model
        /// </summary>
        public Guid? RefFoodServiceParticipationId { get => _RefFoodServiceParticipationId; set => SetProperty(ref _RefFoodServiceParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOptionId"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get => _RefServiceOptionId; set => SetProperty(ref _RefServiceOptionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingTypeId"/> model
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get => _RefELFederalFundingTypeId; set => SetProperty(ref _RefELFederalFundingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            EnrollmentDate = model.EnrollmentDate;
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance;
            ELClassSectionId = model.ELClassSectionId;
            RefIDEAEnvironmentELId = model.RefIDEAEnvironmentELId;
            RefFoodServiceParticipationId = model.RefFoodServiceParticipationId;
            RefServiceOptionId = model.RefServiceOptionId;
            RefELFederalFundingTypeId = model.RefELFederalFundingTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
