//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationNeglected.cs
//* Name:       Neglected or Delinquent Academic Achievement Indicator
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProgramParticipationNeglected : IAutobahnBase
    {
        /// <summary>
        /// Neglected or Delinquent Academic Achievement Indicator
        /// <para>
        /// Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
        /// </para>
        /// </summary>
        System.Boolean? AchievementIndicator { get; set; }

        /// <summary>
        /// Neglected or Delinquent Obtained Employment
        /// <para>
        /// An indication that a Neglected or Delinquent student obtained employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19475">Neglected or Delinquent Obtained Employment</a>
        /// </para>
        /// </summary>
        System.Boolean? ObtainedEmployment { get; set; }

        /// <summary>
        /// Neglected or Delinquent Academic Outcome Indicator
        /// <para>
        /// Student was served by Title I, Part D, Subpart 2 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
        /// </para>
        /// </summary>
        System.Boolean? OutcomeIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefNeglectedProgramType"/> model
        /// </summary>
        Guid? RefNeglectedProgramTypeId { get; set; }

    }
}
