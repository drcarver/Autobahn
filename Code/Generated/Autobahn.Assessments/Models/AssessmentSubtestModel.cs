//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtest Model
     /// </summary>
    public partial class AssessmentSubtestModel : AutobahnBase, Interfaces.IAssessmentSubtest
    {
        /// <summary>
        /// 
        /// </summary>
        public  Abbreviation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ContainerOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaximumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MinimumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OptimalValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublishedDate { get; set; }

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
        public Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentSubtestIdentifierTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefContentStandardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
