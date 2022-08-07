//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12TitleIIILanguageInstructionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12TitleIIILanguageInstructionModel Interface
     /// </summary>
    public partial interface IK12TitleIIILanguageInstructionModel : IAutobahnBase
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
