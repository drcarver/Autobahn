//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationMigrant.cs
//* Name:       Birthdate Verification
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProgramParticipationMigrant : IAutobahnBase
    {
        /// <summary>
        /// Birthdate Verification
        /// <para>
        /// The evidence by which a child's date of birth is confirmed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
        /// </para>
        /// </summary>
        System.String BirthdateVerification { get; set; }

        /// <summary>
        /// Migrant Education Program Continuation of Services Status
        /// <para>
        /// An indication that migrant children are receiving instructional or support services under the continuation of services authority ESEA Title III Section 1304(e)(2)-(3).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19555">Migrant Education Program Continuation of Services Status</a>
        /// </para>
        /// </summary>
        System.Boolean? ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IDesignatedGraduationSchool"/> model
        /// </summary>
        Guid? DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// Immunization Record Flag
        /// <para>
        /// Indicates whether the school or MEP program has immunization records on file for the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19428">Immunization Record Flag</a>
        /// </para>
        /// </summary>
        System.Boolean? ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// Last Qualifying Move Date
        /// <para>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19171">Last Qualifying Move Date</a>
        /// </para>
        /// </summary>
        System.DateTime? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// Migrant Education Program Eligibility Expiration Date
        /// <para>
        /// The year, month, and day on which the child is no longer eligible for the Migrant Education Program. This date should initially be a date equal to 36 months from the Qualifying Arrival Date to indicate the end of MEP eligibility or the student reaches 22 years of age, whichever comes first.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19420">Migrant Education Program Eligibility Expiration Date</a>
        /// </para>
        /// </summary>
        System.DateTime? MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// Migrant Student Qualifying Arrival Date
        /// <para>
        /// The qualifying arrival date (QAD) is the month, date, and year that the child completed a move with his or her parent to enable the parent to find qualifying employment. In some cases, the child and worker may not always move together, in which case the QAD would be the date that the child joins the worker who has  already moved, or the date the worker joins the child who has already moved. The QAD is the date the child's eligibility for the Migrant Education Program begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19422">Migrant Student Qualifying Arrival Date</a>
        /// </para>
        /// </summary>
        System.DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Migrant Prioritized for Services
        /// <para>
        /// An indication that a migratory child 1) is failing to meet, or most at risk of failing to meet, the state's challenging academic content standards and student academic achievement standards; and 2) has experienced interruptions in their education during the regular school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19554">Migrant Prioritized for Services</a>
        /// </para>
        /// </summary>
        System.Boolean? PrioritizedForServices { get; set; }

        /// <summary>
        /// Qualifying Move From City
        /// <para>
        /// The name of the city in which the child resided prior to the qualifying move.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19423">Qualifying Move From City</a>
        /// </para>
        /// </summary>
        System.String QualifyingMoveFromCity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefContinuationOfServicesReason"/> model
        /// </summary>
        Guid? RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMepEnrollmentType"/> model
        /// </summary>
        Guid? RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMepProjectBased"/> model
        /// </summary>
        Guid? RefMepProjectBasedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMepServiceType"/> model
        /// </summary>
        Guid? RefMepServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefQualifyingMoveFromCountry"/> model
        /// </summary>
        Guid? RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefQualifyingMoveFromState"/> model
        /// </summary>
        Guid? RefQualifyingMoveFromStateId { get; set; }

    }
}
