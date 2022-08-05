//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaffEducation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffEducation
     /// </summary>
    public partial interface IELStaffEducation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELStaff"/> model
        /// </summary>
        Guid ELStaffId { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.ECDegreeOrCertificateHolder nullable property
        /// </summary>
        System.Boolean? ECDegreeOrCertificateHolder { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.TotalCollegeCreditsEarned nullable property
        /// </summary>
        System.Decimal? TotalCollegeCreditsEarned { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.TotalApprovedECCreditsEarned nullable property
        /// </summary>
        System.Decimal? TotalApprovedECCreditsEarned { get; set; }

        /// <summary>
        /// Defines the ELStaffEducation.SchoolAgeEducationPSCredits nullable property
        /// </summary>
        System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecialization"/> model
        /// </summary>
        Guid? RefELLevelOfSpecializationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProfessionalDevelopmentTopicArea"/> model
        /// </summary>
        Guid? RefELProfessionalDevelopmentTopicAreaId { get; set; }

    }
}
