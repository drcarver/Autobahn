//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12TitleIIILanguageInstructionModel.cs
//**********************************************************

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
        /// The type of Title III language instructional education programs.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        public Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
