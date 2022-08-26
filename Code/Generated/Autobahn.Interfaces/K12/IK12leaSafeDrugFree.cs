//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12leaSafeDrugFree.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12leaSafeDrugFree Interface
     /// </summary>
    public partial interface IK12leaSafeDrugFree : IAutobahnBase
    {
        System.String Baseline { get; set; }

        System.String BaselineYear { get; set; }

        System.String CollectionFrequency { get; set; }

        System.String IndicatorName { get; set; }

        System.String Instrument { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        Guid K12leaId { get; set; }

        System.String MostRecentCollection { get; set; }

        System.String Performance { get; set; }

        System.String Target { get; set; }

    }
}
