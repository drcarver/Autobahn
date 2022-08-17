//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationAE.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IProgramParticipationAE Interface
     /// </summary>
    public partial interface IProgramParticipationAE : IAutobahnBase
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
        System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// Instructional Activity Hours Completed
        /// <para>
        /// The number of credit hours and/or contact hours successfully completed by a person during a term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19361">Instructional Activity Hours Completed</a>
        /// </para>
        /// </summary>
        System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// Out of Workforce Indicator
        /// <para>
        /// An individual: (A) who is a displaced homemaker, as defined in section 3 of the Workforce Innovation and Opportunity Act (29 U.S.C. 3102); or (B) who (i)(I) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills; or (II) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (ii) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20908">Out of Workforce Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Adult Education Postsecondary Transition Date
        /// <para>
        /// The year, month and day on which a person previously enrolled in adult education entered and began to receive instructional services or training at a postsecondary institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19769">Adult Education Postsecondary Transition Date</a>
        /// </para>
        /// </summary>
        System.DateTime? PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// Proxy Contact Hours
        /// <para>
        /// The number of instructional hours completed by an adult enrolled in a distance learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19776">Proxy Contact Hours</a>
        /// </para>
        /// </summary>
        System.Decimal? ProxyContactHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdultEducationProgramExitReason"/> model
        /// </summary>
        Guid? RefAdultEducationProgramExitReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAeFunctioningLevelAtIntake"/> model
        /// </summary>
        Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAeFunctioningLevelAtPosttest"/> model
        /// </summary>
        Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAeInstructionalProgramType"/> model
        /// </summary>
        Guid? RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAePostsecondaryTransitionAction"/> model
        /// </summary>
        Guid? RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAeSpecialProgramType"/> model
        /// </summary>
        Guid? RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCorrectionalEducationFacilityType"/> model
        /// </summary>
        Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefGoalsForAttendingAdultEducation"/> model
        /// </summary>
        Guid? RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
