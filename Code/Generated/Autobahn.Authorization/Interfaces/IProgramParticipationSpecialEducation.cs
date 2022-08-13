//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationSpecialEducation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgramParticipationSpecialEducation Interface
     /// </summary>
    public partial interface IProgramParticipationSpecialEducation : IAutobahnBase
    {
        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        System.Boolean? AwaitingInitialIDEAEvaluationStatus { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        System.String IDEAPlacementRationale { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        Guid? RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        Guid? RefSpecialEducationExitReasonId { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        System.Decimal? SpecialEducationFTE { get; set; }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        System.DateTime? SpecialEducationServicesExitDate { get; set; }

    }
}
