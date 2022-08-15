//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaSafeDrugFree.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaSafeDrugFree Interface
     /// </summary>
    public partial interface IK12LeaSafeDrugFree : IAutobahnBase
    {
        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String IndicatorName { get; set; }

    }
}
