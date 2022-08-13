//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12ProgramOrService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12ProgramOrService Interface
     /// </summary>
    public partial interface IK12ProgramOrService : IAutobahnBase
    {
        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        System.Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefTitleIProgramTypeId { get; set; }

    }
}
