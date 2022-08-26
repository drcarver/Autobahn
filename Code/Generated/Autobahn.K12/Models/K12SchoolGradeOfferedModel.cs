//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolGradeOfferedModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12schoolGradeOffered Model
     /// </summary>
    public partial class K12schoolGradeOfferedModel : AutobahnBase, IK12schoolGradeOffered
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        public Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
