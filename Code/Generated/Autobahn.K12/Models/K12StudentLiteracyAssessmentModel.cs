//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentLiteracyAssessment Model
     /// </summary>
    public partial class K12StudentLiteracyAssessmentModel : AutobahnBase, Interfaces.IK12StudentLiteracyAssessment
    {
        /// <summary>
        /// 
        /// </summary>
        public  LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LiteracyPreTestStatus { get; set; }

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
        public Guid? RefLiteracyAssessmentId { get; set; }

    }
}
