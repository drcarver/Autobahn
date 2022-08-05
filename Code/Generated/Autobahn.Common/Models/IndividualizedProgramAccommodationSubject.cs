//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAccommodationSubject.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubject
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubject : AutobahnBase, Interfaces.IIndividualizedProgramAccommodationSubject
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
