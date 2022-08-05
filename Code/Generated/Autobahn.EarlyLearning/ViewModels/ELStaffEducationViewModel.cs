//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffEducationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffEducationViewModel
     /// </summary>
    public partial class ELStaffEducationViewModel : ViewModelBase, Interfaces.IELStaffEducation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaffEducation";

        // member variable for the ELStaffId property
        private Guid _ELStaffId;

        // member variable for the ECDegreeOrCertificateHolder property
        private System.Boolean? _ECDegreeOrCertificateHolder;

        // member variable for the TotalCollegeCreditsEarned property
        private System.Decimal? _TotalCollegeCreditsEarned;

        // member variable for the TotalApprovedECCreditsEarned property
        private System.Decimal? _TotalApprovedECCreditsEarned;

        // member variable for the SchoolAgeEducationPSCredits property
        private System.Decimal? _SchoolAgeEducationPSCredits;

        // member variable for the RefELLevelOfSpecializationId property
        private Guid? _RefELLevelOfSpecializationId;

        // member variable for the RefELProfessionalDevelopmentTopicAreaId property
        private Guid? _RefELProfessionalDevelopmentTopicAreaId;

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
        /// The title of the ELStaffEducationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ELStaffId"/> model
        /// </summary>
        public Guid ELStaffId { get => _ELStaffId; set => SetProperty(ref _ELStaffId, value); }

        public System.Boolean? ECDegreeOrCertificateHolder { get => _ECDegreeOrCertificateHolder; set => SetProperty(ref _ECDegreeOrCertificateHolder, value); }

        public System.Decimal? TotalCollegeCreditsEarned { get => _TotalCollegeCreditsEarned; set => SetProperty(ref _TotalCollegeCreditsEarned, value); }

        public System.Decimal? TotalApprovedECCreditsEarned { get => _TotalApprovedECCreditsEarned; set => SetProperty(ref _TotalApprovedECCreditsEarned, value); }

        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecializationId"/> model
        /// </summary>
        public Guid? RefELLevelOfSpecializationId { get => _RefELLevelOfSpecializationId; set => SetProperty(ref _RefELLevelOfSpecializationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProfessionalDevelopmentTopicAreaId"/> model
        /// </summary>
        public Guid? RefELProfessionalDevelopmentTopicAreaId { get => _RefELProfessionalDevelopmentTopicAreaId; set => SetProperty(ref _RefELProfessionalDevelopmentTopicAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            ELStaffId = model.ELStaffId;
            ECDegreeOrCertificateHolder = model.ECDegreeOrCertificateHolder;
            TotalCollegeCreditsEarned = model.TotalCollegeCreditsEarned;
            TotalApprovedECCreditsEarned = model.TotalApprovedECCreditsEarned;
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits;
            RefELLevelOfSpecializationId = model.RefELLevelOfSpecializationId;
            RefELProfessionalDevelopmentTopicAreaId = model.RefELProfessionalDevelopmentTopicAreaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
