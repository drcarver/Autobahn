//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12titleIiilanguageInstructionModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12titleIiilanguageInstruction Model
     /// </summary>
    public partial class K12titleIiilanguageInstructionModel : AutobahnBase, IK12titleIiilanguageInstruction
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
        /// </summary>
        public Guid RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    }
}
