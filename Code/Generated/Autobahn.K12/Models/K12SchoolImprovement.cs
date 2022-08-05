//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolImprovement.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolImprovement
     /// </summary>
    public partial class K12SchoolImprovement : AutobahnBase, Interfaces.IK12SchoolImprovement
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
        /// </summary>
        public Guid? RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// Defines the K12SchoolImprovement.SchoolImprovementExitDate nullable property
        /// </summary>
        public System.DateTime? SchoolImprovementExitDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
