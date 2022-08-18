//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEducationModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffEducation Model
     /// </summary>
    public partial class ELStaffEducationModel : AutobahnBase, Interfaces.IELStaffEducation
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
        public System.Boolean? ECDegreeOrCertificateHolder { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELStaff"/> model
        /// </summary>
        public Guid ELStaffId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLevelOfSpecialization"/> model
        /// </summary>
        public Guid? RefELLevelOfSpecializationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProfessionalDevelopmentTopicArea"/> model
        /// </summary>
        public Guid? RefELProfessionalDevelopmentTopicAreaId { get; set; }

        /// <summary>
        /// Number of School-age Education Postsecondary Credit Hours
        /// <para>
        /// The number of college course credit hours an individual has successfully completed that are related to K-12 education, parks and recreation, and juvenile justice.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19815">Number of School-age Education Postsecondary Credit Hours</a>
        /// </para>
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get; set; }

        /// <summary>
        /// Total Approved Early Childhood Credits Earned
        /// <para>
        /// Total semester credits earned in early childhood regardless of whether credits are earned as part of an early childhood degree program, other degree program or outside of a degree program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19787">Total Approved Early Childhood Credits Earned</a>
        /// </para>
        /// </summary>
        public System.Decimal? TotalApprovedECCreditsEarned { get; set; }

        /// <summary>
        /// Early Learning Staff Total College Credits Earned
        /// <para>
        /// Total number of college credits earned, including all credits within a degree and outside a degree, regardless of whether they all are early childhood credits.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19791">Early Learning Staff Total College Credits Earned</a>
        /// </para>
        /// </summary>
        public System.Decimal? TotalCollegeCreditsEarned { get; set; }

    }
}
