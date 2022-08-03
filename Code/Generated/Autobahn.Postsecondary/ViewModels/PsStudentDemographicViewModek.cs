//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentDemographicViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentDemographicViewModel
     /// </summary>
    public partial class PsStudentDemographicViewModel : BindableBase, IPsStudentDemographic
    {
#region "Backing Fields"
        // member variable for the NumberOfDependents property
        private System.Int32? _NumberOfDependents;

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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Int32? NumberOfDependents { get => _NumberOfDependents; set => SetProperty(ref _NumberOfDependents, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatusId"/> model
        /// </summary>
        public Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyTypeId"/> model
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyTypeId"/> model
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepTypeId"/> model
        /// </summary>
        public Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevelId"/> model
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevelId"/> model
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusionId"/> model
        /// </summary>
        public Guid? RefCohortExclusionId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Boolean? ChildrenOfFallenHeroesIndicator { get => _ChildrenOfFallenHeroesIndicator; set => SetProperty(ref _ChildrenOfFallenHeroesIndicator, value); }

        public System.Boolean? EmancipatedMinor { get => _EmancipatedMinor; set => SetProperty(ref _EmancipatedMinor, value); }

        public System.Boolean? FirstGenerationCollegeStudent { get => _FirstGenerationCollegeStudent; set => SetProperty(ref _FirstGenerationCollegeStudent, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsTypeId"/> model
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPsStudentDemographic model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            ChildrenOfFallenHeroesIndicator = model.ChildrenOfFallenHeroesIndicator;
            EmancipatedMinor = model.EmancipatedMinor;
            FirstGenerationCollegeStudent = model.FirstGenerationCollegeStudent;
            RefNumberOfDependentsTypeId = model.RefNumberOfDependentsTypeId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
