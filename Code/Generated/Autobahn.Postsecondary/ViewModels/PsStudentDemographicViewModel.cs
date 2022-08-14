//**********************************************************
//* DomainName: Postsecondary (PS)
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

        // member variable for the ChildrenOfFallenHeroesIndicator property
        private System.Boolean? _ChildrenOfFallenHeroesIndicator;

        // member variable for the EmancipatedMinor property
        private System.Boolean? _EmancipatedMinor;

        // member variable for the FirstGenerationCollegeStudent property
        private System.Boolean? _FirstGenerationCollegeStudent;

        // member variable for the NumberOfDependents property
        private System.Int32? _NumberOfDependents;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefCampusResidencyTypeId property
        private Guid? _RefCampusResidencyTypeId;

        // member variable for the RefCohortExclusionId property
        private Guid? _RefCohortExclusionId;

        // member variable for the RefDependencyStatusId property
        private Guid? _RefDependencyStatusId;

        // member variable for the RefMaternalEducationLevelId property
        private Guid? _RefMaternalEducationLevelId;

        // member variable for the RefNumberOfDependentsTypeId property
        private Guid? _RefNumberOfDependentsTypeId;

        // member variable for the RefPaternalEducationLevelId property
        private Guid? _RefPaternalEducationLevelId;

        // member variable for the RefPsLepTypeId property
        private Guid? _RefPsLepTypeId;

        // member variable for the RefTuitionResidencyTypeId property
        private Guid? _RefTuitionResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentDemographicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Boolean? ChildrenOfFallenHeroesIndicator { get => _ChildrenOfFallenHeroesIndicator; set => SetProperty(ref _ChildrenOfFallenHeroesIndicator, value); }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Boolean? EmancipatedMinor { get => _EmancipatedMinor; set => SetProperty(ref _EmancipatedMinor, value); }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Boolean? FirstGenerationCollegeStudent { get => _FirstGenerationCollegeStudent; set => SetProperty(ref _FirstGenerationCollegeStudent, value); }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Int32? NumberOfDependents { get => _NumberOfDependents; set => SetProperty(ref _NumberOfDependents, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyType"/> model
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get => _RefCampusResidencyTypeId; set => SetProperty(ref _RefCampusResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusion"/> model
        /// </summary>
        public Guid? RefCohortExclusionId { get => _RefCohortExclusionId; set => SetProperty(ref _RefCohortExclusionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        public Guid? RefDependencyStatusId { get => _RefDependencyStatusId; set => SetProperty(ref _RefDependencyStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevel"/> model
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get => _RefMaternalEducationLevelId; set => SetProperty(ref _RefMaternalEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsType"/> model
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get => _RefNumberOfDependentsTypeId; set => SetProperty(ref _RefNumberOfDependentsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevel"/> model
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get => _RefPaternalEducationLevelId; set => SetProperty(ref _RefPaternalEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepType"/> model
        /// </summary>
        public Guid? RefPsLepTypeId { get => _RefPsLepTypeId; set => SetProperty(ref _RefPsLepTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyType"/> model
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get => _RefTuitionResidencyTypeId; set => SetProperty(ref _RefTuitionResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildrenOfFallenHeroesIndicator = model.ChildrenOfFallenHeroesIndicator;
            EmancipatedMinor = model.EmancipatedMinor;
            FirstGenerationCollegeStudent = model.FirstGenerationCollegeStudent;
            NumberOfDependents = model.NumberOfDependents;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefCampusResidencyTypeId = model.RefCampusResidencyTypeId;
            RefCohortExclusionId = model.RefCohortExclusionId;
            RefDependencyStatusId = model.RefDependencyStatusId;
            RefMaternalEducationLevelId = model.RefMaternalEducationLevelId;
            RefNumberOfDependentsTypeId = model.RefNumberOfDependentsTypeId;
            RefPaternalEducationLevelId = model.RefPaternalEducationLevelId;
            RefPsLepTypeId = model.RefPsLepTypeId;
            RefTuitionResidencyTypeId = model.RefTuitionResidencyTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
