//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessmentAdministration
    {
        /// <summary>
        /// 
        /// </summary>
        public  AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinishTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Name { get; set; }

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
        public  StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartTime { get; set; }

    }
}
