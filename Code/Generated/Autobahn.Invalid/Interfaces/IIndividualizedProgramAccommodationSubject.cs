//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAccommodationSubject.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodationSubject Interface
     /// </summary>
    public partial interface IIndividualizedProgramAccommodationSubject : IAutobahnBase
    {
        /// <summary>
        /// The intended major subject area of the education course.
        /// </summary>
        Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// The intended major subject area of the education course.
        /// </summary>
        Guid RefSCEDCourseSubjectAreaId { get; set; }

    }
}
