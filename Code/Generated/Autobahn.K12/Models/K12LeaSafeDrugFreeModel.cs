//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaSafeDrugFree Model
     /// </summary>
    public partial class K12LeaSafeDrugFreeModel : AutobahnBase, Interfaces.IK12LeaSafeDrugFree
    {
        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String IndicatorName { get; set; }

    }
}
