//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12titleIiilanguageInstruction.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12titleIiilanguageInstruction Interface
     /// </summary>
    public partial interface IK12titleIiilanguageInstruction : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
        /// </summary>
        Guid RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    }
}
