//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Program Model
     /// </summary>
    public partial class ProgramModel : AutobahnBase, Interfaces.IProgram
    {
        /// <summary>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </summary>
        public System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </summary>
        public Guid OrganizationId { get; set; }

    }
}
