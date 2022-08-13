//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeLevelsApprovedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolGradeLevelsApproved Model
     /// </summary>
    public partial class K12SchoolGradeLevelsApprovedModel : AutobahnBase, Interfaces.IK12SchoolGradeLevelsApproved
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
