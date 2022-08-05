//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAccommodationSubject.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodationSubject
     /// </summary>
    public partial interface IIndividualizedProgramAccommodationSubject : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAccommodation"/> model
        /// </summary>
        Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        Guid RefSCEDCourseSubjectAreaId { get; set; }

    }
}
