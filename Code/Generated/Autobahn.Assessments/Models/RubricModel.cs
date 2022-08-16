//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Rubric Model
     /// </summary>
    public partial class RubricModel : AutobahnBase, Interfaces.IRubric
    {
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
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  UrlReference { get; set; }

    }
}
