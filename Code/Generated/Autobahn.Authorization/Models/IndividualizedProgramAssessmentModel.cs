//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessment Model
     /// </summary>
    public partial class IndividualizedProgramAssessmentModel : AutobahnBase, Interfaces.IIndividualizedProgramAssessment
    {
        /// <summary>
        /// A statement of why-
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// A statement of why-
        /// </summary>
        public System.String IEPAlternativeAssessmentRationale { get; set; }

        /// <summary>
        /// A statement of why-
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

    }
}
