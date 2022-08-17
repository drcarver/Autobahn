//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12TitleIIILanguageInstruction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12TitleIIILanguageInstruction Interface
     /// </summary>
    public partial interface IK12TitleIIILanguageInstruction : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
