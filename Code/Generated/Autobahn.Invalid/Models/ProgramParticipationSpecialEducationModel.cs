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

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.String IDEAPlacementRationale { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public Guid? RefSpecialEducationExitReasonId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.Decimal? SpecialEducationFTE { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.DateTime? SpecialEducationServicesExitDate { get; set; }

    }
}
