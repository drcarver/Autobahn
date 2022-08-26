//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaGradeOfferedModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaGradeOffered Model
     /// </summary>
    public partial class K12leaGradeOfferedModel : AutobahnBase, IK12leaGradeOffered
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
