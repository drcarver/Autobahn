//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12TitleIIILanguageInstructionModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12TitleIIILanguageInstruction Model
     /// </summary>
    public partial class K12TitleIIILanguageInstructionModel : AutobahnBase, Interfaces.IK12TitleIIILanguageInstruction
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        public Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
