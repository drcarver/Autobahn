//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAccommodationSubjectModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodationSubjectModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramAccommodationSubjectModel : IAutobahnBase
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
