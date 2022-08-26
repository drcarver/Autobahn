//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12schoolGradeOffered.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12schoolGradeOffered Interface
     /// </summary>
    public partial interface IK12schoolGradeOffered : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        Guid RefGradeLevelId { get; set; }

    }
}
