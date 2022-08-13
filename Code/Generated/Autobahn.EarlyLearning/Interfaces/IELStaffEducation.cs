//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELStaffEducation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffEducation Interface
     /// </summary>
    public partial interface IELStaffEducation : IAutobahnBase
    {
        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        System.Boolean? ECDegreeOrCertificateHolder { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        Guid ELStaffId { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        Guid? RefELLevelOfSpecializationId { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        Guid? RefELProfessionalDevelopmentTopicAreaId { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        System.Decimal? TotalApprovedECCreditsEarned { get; set; }

        /// <summary>
        /// The extent to which a person concentrates upon a particular subject matter area during his or her period of study at an educational institution.
        /// </summary>
        System.Decimal? TotalCollegeCreditsEarned { get; set; }

    }
}
