//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTeacherPrepModel.cs
//* Name:       Supervised Clinical Experience Clock Hours
//* Definition: An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
     /// </summary>
    public partial class ProgramParticipationTeacherPrepModel : AutobahnBase, Interfaces.IProgramParticipationTeacherPrep
    {
        /// <summary>
        /// Supervised Clinical Experience Clock Hours
        /// <para>
        /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
        /// </para>
        /// </summary>
        public System.Int32? ClinicalExperienceClockHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensure"/> model
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidate"/> model
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperience"/> model
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

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

    }
}
