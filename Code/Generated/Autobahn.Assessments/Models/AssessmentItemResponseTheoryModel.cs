//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseTheoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemResponseTheory Model
     /// </summary>
    public partial class AssessmentItemResponseTheoryModel : AutobahnBase, Interfaces.IAssessmentItemResponseTheory
    {
        /// <summary>
        /// 
        /// </summary>
        public  DIFValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  KappaValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ParameterA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterD1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterD2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterD3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterD4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterD5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParameterD6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PointBiserialCorrelationValue { get; set; }

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
        public  RefItemResponseTheoryDifficultyCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefItemResponseTheoryKappaAlgorithmId { get; set; }

    }
}
