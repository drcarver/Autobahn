//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationSpecialEducationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationSpecialEducation Model
     /// </summary>
    public partial class ProgramParticipationSpecialEducationModel : AutobahnBase, Interfaces.IProgramParticipationSpecialEducation
    {
        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get; set; }

    }
}
