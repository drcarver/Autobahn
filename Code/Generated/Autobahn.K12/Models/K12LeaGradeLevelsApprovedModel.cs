//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaGradeLevelsApprovedModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaGradeLevelsApproved Model
     /// </summary>
    public partial class K12leaGradeLevelsApprovedModel : AutobahnBase, IK12leaGradeLevelsApproved
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
