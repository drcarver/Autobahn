//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentLiteracyAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentLiteracyAssessment Interface
     /// </summary>
    public partial interface IK12StudentLiteracyAssessment : IAutobahnBase
    {
        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        Guid? RefLiteracyAssessmentId { get; set; }

    }
}
