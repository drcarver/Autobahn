//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEducationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the ECDegreeOrCertificateHolder property
        private System.Boolean? _ECDegreeOrCertificateHolder;

        // member variable for the ELStaffId property
        private Guid _ELStaffId;

        // member variable for the RefELLevelOfSpecializationId property
        private Guid? _RefELLevelOfSpecializationId;

        // member variable for the RefELProfessionalDevelopmentTopicAreaId property
        private Guid? _RefELProfessionalDevelopmentTopicAreaId;

        // member variable for the SchoolAgeEducationPSCredits property
        private System.Decimal? _SchoolAgeEducationPSCredits;

        // member variable for the TotalApprovedECCreditsEarned property
        private System.Decimal? _TotalApprovedECCreditsEarned;

        // member variable for the TotalCollegeCreditsEarned property
        private System.Decimal? _TotalCollegeCreditsEarned;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELStaffEducationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Boolean? ECDegreeOrCertificateHolder { get => _ECDegreeOrCertificateHolder; set => SetProperty(ref _ECDegreeOrCertificateHolder, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELStaff"/> model
        /// </summary>
        public Guid ELStaffId { get => _ELStaffId; set => SetProperty(ref _ELStaffId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecialization"/> model
        /// </summary>
        public Guid? RefELLevelOfSpecializationId { get => _RefELLevelOfSpecializationId; set => SetProperty(ref _RefELLevelOfSpecializationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProfessionalDevelopmentTopicArea"/> model
        /// </summary>
        public Guid? RefELProfessionalDevelopmentTopicAreaId { get => _RefELProfessionalDevelopmentTopicAreaId; set => SetProperty(ref _RefELProfessionalDevelopmentTopicAreaId, value); }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Decimal? TotalApprovedECCreditsEarned { get => _TotalApprovedECCreditsEarned; set => SetProperty(ref _TotalApprovedECCreditsEarned, value); }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        public System.Decimal? TotalCollegeCreditsEarned { get => _TotalCollegeCreditsEarned; set => SetProperty(ref _TotalCollegeCreditsEarned, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            ECDegreeOrCertificateHolder = model.ECDegreeOrCertificateHolder;
            ELStaffId = model.ELStaffId;
            RefELLevelOfSpecializationId = model.RefELLevelOfSpecializationId;
            RefELProfessionalDevelopmentTopicAreaId = model.RefELProfessionalDevelopmentTopicAreaId;
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits;
            TotalApprovedECCreditsEarned = model.TotalApprovedECCreditsEarned;
            TotalCollegeCreditsEarned = model.TotalCollegeCreditsEarned;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
