//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolImprovementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolImprovement Model
     /// </summary>
    public partial class K12SchoolImprovementModel : AutobahnBase, Interfaces.IK12SchoolImprovement
    {
        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        public Guid? RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        public System.DateTime? SchoolImprovementExitDate { get; set; }

    }
}
