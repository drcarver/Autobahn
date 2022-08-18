//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The ProgramParticipationAE Model
     /// </summary>
    public partial class ProgramParticipationAEModel : AutobahnBase, Interfaces.IProgramParticipationAE
    {
        /// <summary>
        /// Career-Technical-Adult Education Displaced Homemaker Indicator
        /// <para>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19084">Career-Technical-Adult Education Displaced Homemaker Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// Instructional Activity Hours Completed
        /// <para>
        /// The number of credit hours and/or contact hours successfully completed by a person during a term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19361">Instructional Activity Hours Completed</a>
        /// </para>
        /// </summary>
        public System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// Out of Workforce Indicator
        /// <para>
        /// An individual: (A) who is a displaced homemaker, as defined in section 3 of the Workforce Innovation and Opportunity Act (29 U.S.C. 3102); or (B) who (i)(I) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills; or (II) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (ii) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20908">Out of Workforce Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Adult Education Postsecondary Transition Date
        /// <para>
        /// The year, month and day on which a person previously enrolled in adult education entered and began to receive instructional services or training at a postsecondary institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19769">Adult Education Postsecondary Transition Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// Proxy Contact Hours
        /// <para>
        /// The number of instructional hours completed by an adult enrolled in a distance learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19776">Proxy Contact Hours</a>
        /// </para>
        /// </summary>
        public System.Decimal? ProxyContactHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
        /// </summary>
        public Guid? RefAdultEducationProgramExitReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
        /// </summary>
        public Guid? RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
        /// </summary>
        public Guid? RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
        /// </summary>
        public Guid? RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
        /// </summary>
        public Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
        /// </summary>
        public Guid? RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
