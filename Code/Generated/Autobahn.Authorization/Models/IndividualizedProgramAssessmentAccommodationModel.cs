//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAssessmentAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodation Model
     /// </summary>
    public partial class IndividualizedProgramAssessmentAccommodationModel : AutobahnBase, Interfaces.IIndividualizedProgramAssessmentAccommodation
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid IndividualizedProgramAssessmentId { get; set; }

    }
}
