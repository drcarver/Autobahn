//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentAcademicHonor.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentAcademicHonor Interface
     /// </summary>
    public partial interface IK12StudentAcademicHonor : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         HonorDescription { get; set; }

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
        Guid? RefAcademicHonorTypeId { get; set; }

    }
}
