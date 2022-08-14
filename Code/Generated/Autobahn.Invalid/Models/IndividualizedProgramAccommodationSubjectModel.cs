//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAccommodationSubjectModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubject Model
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectModel : AutobahnBase, Interfaces.IIndividualizedProgramAccommodationSubject
    {
        /// <summary>
        /// The intended major subject area of the education course.
        /// </summary>
        public Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// The intended major subject area of the education course.
        /// </summary>
        public Guid RefSCEDCourseSubjectAreaId { get; set; }

    }
}
