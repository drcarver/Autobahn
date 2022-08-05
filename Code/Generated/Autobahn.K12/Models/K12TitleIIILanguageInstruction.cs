//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12TitleIIILanguageInstruction.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12TitleIIILanguageInstruction
     /// </summary>
    public partial class K12TitleIIILanguageInstruction : AutobahnBase, Interfaces.IK12TitleIIILanguageInstruction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        public Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
