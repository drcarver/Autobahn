//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolImprovementModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12schoolImprovement Model
     /// </summary>
    public partial class K12schoolImprovementModel : AutobahnBase, IK12schoolImprovement
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        public Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
        /// </summary>
        public Guid? RefSigInterventionTypeId { get; set; }

        public DateTime? SchoolImprovementExitDate { get; set; }

    }
}
