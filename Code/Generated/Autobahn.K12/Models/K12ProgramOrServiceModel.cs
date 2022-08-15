//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12ProgramOrService Model
     /// </summary>
    public partial class K12ProgramOrServiceModel : AutobahnBase, Interfaces.IK12ProgramOrService
    {
        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

    }
}
