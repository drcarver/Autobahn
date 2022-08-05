//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12TitleIIILanguageInstruction.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12TitleIIILanguageInstruction
     /// </summary>
    public partial interface IK12TitleIIILanguageInstruction : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
