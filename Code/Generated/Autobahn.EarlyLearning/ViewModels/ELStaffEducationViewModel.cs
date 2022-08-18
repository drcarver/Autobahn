//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEducationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffEducation View Model
     /// </summary>
    public partial class ELStaffEducationViewModel : ViewModelBase, Interfaces.IELStaffEducation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaffEducation";

        // ECDegreeOrCertificateHolder -- (backing property for Early Childhood Degree or Certificate Holder)
        private System.Boolean? _ECDegreeOrCertificateHolder;

        // member variable for the ELStaffId property
        private Guid _ELStaffId;

        // RefELLevelOfSpecializationId -- (backing property for Level of Specialization in Early Learning)
        private Guid? _RefELLevelOfSpecializationId;

        // RefELProfessionalDevelopmentTopicAreaId -- (backing property for Early Learning Professional Development Topic Area)
        private Guid? _RefELProfessionalDevelopmentTopicAreaId;

        // SchoolAgeEducationPSCredits -- (backing property for Number of School-age Education Postsecondary Credit Hours)
        private System.Decimal? _SchoolAgeEducationPSCredits;

        // TotalApprovedECCreditsEarned -- (backing property for Total Approved Early Childhood Credits Earned)
        private System.Decimal? _TotalApprovedECCreditsEarned;

        // TotalCollegeCreditsEarned -- (backing property for Early Learning Staff Total College Credits Earned)
        private System.Decimal? _TotalCollegeCreditsEarned;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Early Childhood Degree or Certificate Holder
        /// <para>
        /// Staff has a degree in early childhood regardless of level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19786">Early Childhood Degree or Certificate Holder</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ECDegreeOrCertificateHolder { get => _ECDegreeOrCertificateHolder; set => SetProperty(ref _ECDegreeOrCertificateHolder, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELStaff"/> model
        /// </summary>
        public Guid ELStaffId { get => _ELStaffId; set => SetProperty(ref _ELStaffId, value); }

        /// <summary>
        /// Level of Specialization in Early Learning
        /// <para>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19340">Level of Specialization in Early Learning</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELLevelOfSpecializationId { get => _RefELLevelOfSpecializationId; set => SetProperty(ref _RefELLevelOfSpecializationId, value); }

        /// <summary>
        /// Early Learning Professional Development Topic Area
        /// <para>
        /// The topical area of competence needed for Staff professional development.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20304">Early Learning Professional Development Topic Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELProfessionalDevelopmentTopicAreaId { get => _RefELProfessionalDevelopmentTopicAreaId; set => SetProperty(ref _RefELProfessionalDevelopmentTopicAreaId, value); }

        /// <summary>
        /// Number of School-age Education Postsecondary Credit Hours
        /// <para>
        /// The number of college course credit hours an individual has successfully completed that are related to K-12 education, parks and recreation, and juvenile justice.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19815">Number of School-age Education Postsecondary Credit Hours</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        /// <summary>
        /// Total Approved Early Childhood Credits Earned
        /// <para>
        /// Total semester credits earned in early childhood regardless of whether credits are earned as part of an early childhood degree program, other degree program or outside of a degree program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19787">Total Approved Early Childhood Credits Earned</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? TotalApprovedECCreditsEarned { get => _TotalApprovedECCreditsEarned; set => SetProperty(ref _TotalApprovedECCreditsEarned, value); }

        /// <summary>
        /// Early Learning Staff Total College Credits Earned
        /// <para>
        /// Total number of college credits earned, including all credits within a degree and outside a degree, regardless of whether they all are early childhood credits.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19791">Early Learning Staff Total College Credits Earned</a>
        /// </para>
        /// </summary>
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
            ECDegreeOrCertificateHolder = model.ECDegreeOrCertificateHolder; // Early Childhood Degree or Certificate Holder
            ELStaffId = model.ELStaffId; // 
            RefELLevelOfSpecializationId = model.RefELLevelOfSpecializationId; // Level of Specialization in Early Learning
            RefELProfessionalDevelopmentTopicAreaId = model.RefELProfessionalDevelopmentTopicAreaId; // Early Learning Professional Development Topic Area
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits; // Number of School-age Education Postsecondary Credit Hours
            TotalApprovedECCreditsEarned = model.TotalApprovedECCreditsEarned; // Total Approved Early Childhood Credits Earned
            TotalCollegeCreditsEarned = model.TotalCollegeCreditsEarned; // Early Learning Staff Total College Credits Earned
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
