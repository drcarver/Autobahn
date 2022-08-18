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
        /// Early Childhood Degree or Certificate Holder
        /// <para>
        /// Staff has a degree in early childhood regardless of level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19786">Early Childhood Degree or Certificate Holder</a>
        /// </para>
        /// </summary>
        System.Boolean? ECDegreeOrCertificateHolder { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELStaff"/> model
        /// </summary>
        Guid ELStaffId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecialization"/> model
        /// </summary>
        Guid? RefELLevelOfSpecializationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProfessionalDevelopmentTopicArea"/> model
        /// </summary>
        Guid? RefELProfessionalDevelopmentTopicAreaId { get; set; }

        /// <summary>
        /// Number of School-age Education Postsecondary Credit Hours
        /// <para>
        /// The number of college course credit hours an individual has successfully completed that are related to K-12 education, parks and recreation, and juvenile justice.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19815">Number of School-age Education Postsecondary Credit Hours</a>
        /// </para>
        /// </summary>
        System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// Total Approved Early Childhood Credits Earned
        /// <para>
        /// Total semester credits earned in early childhood regardless of whether credits are earned as part of an early childhood degree program, other degree program or outside of a degree program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19787">Total Approved Early Childhood Credits Earned</a>
        /// </para>
        /// </summary>
        System.Decimal? TotalApprovedECCreditsEarned { get; set; }

        /// <summary>
        /// Early Learning Staff Total College Credits Earned
        /// <para>
        /// Total number of college credits earned, including all credits within a degree and outside a degree, regardless of whether they all are early childhood credits.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19791">Early Learning Staff Total College Credits Earned</a>
        /// </para>
        /// </summary>
        System.Decimal? TotalCollegeCreditsEarned { get; set; }

    }
}
