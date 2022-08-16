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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SchoolImprovementExitDate { get; set; }

    }
}
