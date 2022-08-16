//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _ChildrenOfFallenHeroesIndicator;

        // member variable for the EmancipatedMinor property
        private  _EmancipatedMinor;

        // member variable for the FirstGenerationCollegeStudent property
        private  _FirstGenerationCollegeStudent;

        // member variable for the NumberOfDependents property
        private  _NumberOfDependents;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCampusResidencyTypeId property
        private Guid? _RefCampusResidencyTypeId;

        // member variable for the RefCohortExclusionId property
        private  _RefCohortExclusionId;

        // member variable for the RefDependencyStatusId property
        private  _RefDependencyStatusId;

        // member variable for the RefMaternalEducationLevelId property
        private  _RefMaternalEducationLevelId;

        // member variable for the RefNumberOfDependentsTypeId property
        private  _RefNumberOfDependentsTypeId;

        // member variable for the RefPaternalEducationLevelId property
        private  _RefPaternalEducationLevelId;

        // member variable for the RefPsLepTypeId property
        private  _RefPsLepTypeId;

        // member variable for the RefTuitionResidencyTypeId property
        private  _RefTuitionResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ChildrenOfFallenHeroesIndicator { get => _ChildrenOfFallenHeroesIndicator; set => SetProperty(ref _ChildrenOfFallenHeroesIndicator, value); }

        /// <summary>
        /// </summary>
        public  EmancipatedMinor { get => _EmancipatedMinor; set => SetProperty(ref _EmancipatedMinor, value); }

        /// <summary>
        /// </summary>
        public  FirstGenerationCollegeStudent { get => _FirstGenerationCollegeStudent; set => SetProperty(ref _FirstGenerationCollegeStudent, value); }

        /// <summary>
        /// </summary>
        public  NumberOfDependents { get => _NumberOfDependents; set => SetProperty(ref _NumberOfDependents, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyType"/> model
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get => _RefCampusResidencyTypeId; set => SetProperty(ref _RefCampusResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusion"/> model
        /// </summary>
        public  RefCohortExclusionId { get => _RefCohortExclusionId; set => SetProperty(ref _RefCohortExclusionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        public  RefDependencyStatusId { get => _RefDependencyStatusId; set => SetProperty(ref _RefDependencyStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevel"/> model
        /// </summary>
        public  RefMaternalEducationLevelId { get => _RefMaternalEducationLevelId; set => SetProperty(ref _RefMaternalEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsType"/> model
        /// </summary>
        public  RefNumberOfDependentsTypeId { get => _RefNumberOfDependentsTypeId; set => SetProperty(ref _RefNumberOfDependentsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevel"/> model
        /// </summary>
        public  RefPaternalEducationLevelId { get => _RefPaternalEducationLevelId; set => SetProperty(ref _RefPaternalEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepType"/> model
        /// </summary>
        public  RefPsLepTypeId { get => _RefPsLepTypeId; set => SetProperty(ref _RefPsLepTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyType"/> model
        /// </summary>
        public  RefTuitionResidencyTypeId { get => _RefTuitionResidencyTypeId; set => SetProperty(ref _RefTuitionResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildrenOfFallenHeroesIndicator = model.ChildrenOfFallenHeroesIndicator; // 
            EmancipatedMinor = model.EmancipatedMinor; // 
            FirstGenerationCollegeStudent = model.FirstGenerationCollegeStudent; // 
            NumberOfDependents = model.NumberOfDependents; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCampusResidencyTypeId = model.RefCampusResidencyTypeId; // 
            RefCohortExclusionId = model.RefCohortExclusionId; // 
            RefDependencyStatusId = model.RefDependencyStatusId; // 
            RefMaternalEducationLevelId = model.RefMaternalEducationLevelId; // 
            RefNumberOfDependentsTypeId = model.RefNumberOfDependentsTypeId; // 
            RefPaternalEducationLevelId = model.RefPaternalEducationLevelId; // 
            RefPsLepTypeId = model.RefPsLepTypeId; // 
            RefTuitionResidencyTypeId = model.RefTuitionResidencyTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
