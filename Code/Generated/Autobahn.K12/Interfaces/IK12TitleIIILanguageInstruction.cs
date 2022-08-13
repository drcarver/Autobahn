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
        /// The type of Title III language instructional education programs.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
