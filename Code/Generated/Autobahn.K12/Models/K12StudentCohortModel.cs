//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCohort Model
     /// </summary>
    public partial class K12StudentCohortModel : AutobahnBase, Interfaces.IK12StudentCohort
    {
        /// <summary>
        /// 
        /// </summary>
        public  CohortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CohortGraduationYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CohortYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
