//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAccommodationSubject.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodationSubject Interface
     /// </summary>
    public partial interface IIndividualizedProgramAccommodationSubject : IAutobahnBase
    {
        /// <summary>
        /// Individualized Program Accommodation Applicability
        /// <para>
        /// Circumstances in which the accommodation or change to standards or practices will be applied.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20667">Individualized Program Accommodation Applicability</a>
        /// </para>
        /// </summary>
        Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSCEDCourseSubjectArea"/> model
        /// </summary>
        Guid RefSCEDCourseSubjectAreaId { get; set; }

    }
}
