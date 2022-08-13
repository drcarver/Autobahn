//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaGradeLevelsApprovedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaGradeLevelsApproved Model
     /// </summary>
    public partial class K12LeaGradeLevelsApprovedModel : AutobahnBase, Interfaces.IK12LeaGradeLevelsApproved
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
