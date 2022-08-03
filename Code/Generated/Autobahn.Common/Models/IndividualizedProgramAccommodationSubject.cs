//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAccommodationSubject.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubject
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubject : IIndividualizedProgramAccommodationSubject
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAccommodation"/> model
        /// </summary>
        public Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAccommodationSubject.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAccommodationSubject.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
