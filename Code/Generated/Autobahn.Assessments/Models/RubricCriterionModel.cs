//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The RubricCriterion Model
     /// </summary>
    public partial class RubricCriterionModel : AutobahnBase, Interfaces.IRubricCriterion
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Position { get; set; }

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
        public  Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Weight { get; set; }

    }
}
