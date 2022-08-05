//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentDemographicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentDemographicViewModel
     /// </summary>
    public partial class PsStudentDemographicViewModel : ViewModelBase, Interfaces.IPsStudentDemographic
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentDemographic";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the NumberOfDependents property
        private System.Int32? _NumberOfDependents;

        // member variable for the RefDependencyStatusId property
        private Guid? _RefDependencyStatusId;

        // member variable for the RefTuitionResidencyTypeId property
        private Guid? _RefTuitionResidencyTypeId;

        // member variable for the RefCampusResidencyTypeId property
        private Guid? _RefCampusResidencyTypeId;

        // member variable for the RefPsLepTypeId property
        private Guid? _RefPsLepTypeId;

        // member variable for the RefPaternalEducationLevelId property
        private Guid? _RefPaternalEducationLevelId;

        // member variable for the RefMaternalEducationLevelId property
        private Guid? _RefMaternalEducationLevelId;

        // member variable for the RefCohortExclusionId property
        private Guid? _RefCohortExclusionId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the ChildrenOfFallenHeroesIndicator property
        private System.Boolean? _ChildrenOfFallenHeroesIndicator;

        // member variable for the EmancipatedMinor property
        private System.Boolean? _EmancipatedMinor;

        // member variable for the FirstGenerationCollegeStudent property
        private System.Boolean? _FirstGenerationCollegeStudent;

        // member variable for the RefNumberOfDependentsTypeId property
        private Guid? _RefNumberOfDependentsTypeId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentDemographicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Int32? NumberOfDependents { get => _NumberOfDependents; set => SetProperty(ref _NumberOfDependents, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatusId"/> model
        /// </summary>
        public Guid? RefDependencyStatusId { get => _RefDependencyStatusId; set => SetProperty(ref _RefDependencyStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyTypeId"/> model
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get => _RefTuitionResidencyTypeId; set => SetProperty(ref _RefTuitionResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyTypeId"/> model
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get => _RefCampusResidencyTypeId; set => SetProperty(ref _RefCampusResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepTypeId"/> model
        /// </summary>
        public Guid? RefPsLepTypeId { get => _RefPsLepTypeId; set => SetProperty(ref _RefPsLepTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevelId"/> model
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get => _RefPaternalEducationLevelId; set => SetProperty(ref _RefPaternalEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevelId"/> model
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get => _RefMaternalEducationLevelId; set => SetProperty(ref _RefMaternalEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusionId"/> model
        /// </summary>
        public Guid? RefCohortExclusionId { get => _RefCohortExclusionId; set => SetProperty(ref _RefCohortExclusionId, value); }

        public System.Boolean? ChildrenOfFallenHeroesIndicator { get => _ChildrenOfFallenHeroesIndicator; set => SetProperty(ref _ChildrenOfFallenHeroesIndicator, value); }

        public System.Boolean? EmancipatedMinor { get => _EmancipatedMinor; set => SetProperty(ref _EmancipatedMinor, value); }

        public System.Boolean? FirstGenerationCollegeStudent { get => _FirstGenerationCollegeStudent; set => SetProperty(ref _FirstGenerationCollegeStudent, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsTypeId"/> model
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get => _RefNumberOfDependentsTypeId; set => SetProperty(ref _RefNumberOfDependentsTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            NumberOfDependents = model.NumberOfDependents;
            RefDependencyStatusId = model.RefDependencyStatusId;
            RefTuitionResidencyTypeId = model.RefTuitionResidencyTypeId;
            RefCampusResidencyTypeId = model.RefCampusResidencyTypeId;
            RefPsLepTypeId = model.RefPsLepTypeId;
            RefPaternalEducationLevelId = model.RefPaternalEducationLevelId;
            RefMaternalEducationLevelId = model.RefMaternalEducationLevelId;
            RefCohortExclusionId = model.RefCohortExclusionId;
            ChildrenOfFallenHeroesIndicator = model.ChildrenOfFallenHeroesIndicator;
            EmancipatedMinor = model.EmancipatedMinor;
            FirstGenerationCollegeStudent = model.FirstGenerationCollegeStudent;
            RefNumberOfDependentsTypeId = model.RefNumberOfDependentsTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
