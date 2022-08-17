//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationSpecialEducation.cs
//* Name:       Awaiting Initial IDEA Evaluation Status
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProgramParticipationSpecialEducation : IAutobahnBase
    {
        /// <summary>
        /// Awaiting Initial IDEA Evaluation Status
        /// <para>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19031">Awaiting Initial IDEA Evaluation Status</a>
        /// </para>
        /// </summary>
        System.Boolean? AwaitingInitialIDEAEvaluationStatus { get; set; }

        /// <summary>
        /// IDEA Placement Rationale
        /// <para>
        /// The rationale for the placement decision and if applicable, an explanation of the extent, if any, to which the child will not participate with nondisabled children in the regular class and in the activities described in paragraph (a)(4) of CFR. 300.320.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20685">IDEA Placement Rationale</a>
        /// </para>
        /// </summary>
        System.String IDEAPlacementRationale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEAEducationalEnvironmentEC"/> model
        /// </summary>
        Guid? RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEAEducationalEnvironmentSchoolAge"/> model
        /// </summary>
        Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSpecialEducationExitReason"/> model
        /// </summary>
        Guid? RefSpecialEducationExitReasonId { get; set; }

        /// <summary>
        /// Special Education Full Time Equivalency
        /// <para>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20208">Special Education Full Time Equivalency</a>
        /// </para>
        /// </summary>
        System.Decimal? SpecialEducationFTE { get; set; }

        /// <summary>
        /// Special Education Services Exit Date
        /// <para>
        /// The year, month and day a child with disabilities (IDEA) ages 14 through 21 exited special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19263">Special Education Services Exit Date</a>
        /// </para>
        /// </summary>
        System.DateTime? SpecialEducationServicesExitDate { get; set; }

    }
}
