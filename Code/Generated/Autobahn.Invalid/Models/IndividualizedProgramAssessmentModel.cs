//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramAssessment Model
     /// </summary>
    public partial class IndividualizedProgramAssessmentModel : AutobahnBase, Interfaces.IIndividualizedProgramAssessment
    {
        /// <summary>
        /// A statement of why-
        /// </summary>
        public System.String IEPAlternativeAssessmentRationale { get; set; }

    }
}
