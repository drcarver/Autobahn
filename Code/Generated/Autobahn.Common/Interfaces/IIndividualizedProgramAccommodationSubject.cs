//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAccommodationSubject.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodationSubject
     /// </summary>
    public partial interface IIndividualizedProgramAccommodationSubject
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAccommodation"/> model
        /// </summary>
        Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        Guid RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAccommodationSubject.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAccommodationSubject.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
