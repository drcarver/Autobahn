//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerAction Model
     /// </summary>
    public partial class LearnerActionModel : AutobahnBase, Interfaces.ILearnerAction
    {
        /// <summary>
        /// 
        /// </summary>
        public  LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearnerActionDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearnerActionObjectType { get; set; }

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
        public Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Value { get; set; }

    }
}
