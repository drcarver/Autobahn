//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Assessment Model
     /// </summary>
    public partial class AssessmentModel : AutobahnBase, Interfaces.IAssessment
    {
        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFamilyShortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentRevisionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IdentificationSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Objective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Provider { get; set; }

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
        public  RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ShortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

    }
}
