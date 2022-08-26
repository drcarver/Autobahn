//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaSafeDrugFreeModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaSafeDrugFree Model
     /// </summary>
    public partial class K12leaSafeDrugFreeModel : AutobahnBase, IK12leaSafeDrugFree
    {
        public System.String Baseline { get; set; }

        public System.String BaselineYear { get; set; }

        public System.String CollectionFrequency { get; set; }

        public System.String IndicatorName { get; set; }

        public System.String Instrument { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        public System.String MostRecentCollection { get; set; }

        public System.String Performance { get; set; }

        public System.String Target { get; set; }

    }
}
