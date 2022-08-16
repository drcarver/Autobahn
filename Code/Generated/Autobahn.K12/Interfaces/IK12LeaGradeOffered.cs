//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaGradeOffered.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaGradeOffered Interface
     /// </summary>
    public partial interface IK12LeaGradeOffered : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefGradeLevelId { get; set; }

    }
}
