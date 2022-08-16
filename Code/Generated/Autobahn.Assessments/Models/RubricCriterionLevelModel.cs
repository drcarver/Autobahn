//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The RubricCriterionLevel Model
     /// </summary>
    public partial class RubricCriterionLevelModel : AutobahnBase, Interfaces.IRubricCriterionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Quality { get; set; }

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
        public  Score { get; set; }

    }
}
