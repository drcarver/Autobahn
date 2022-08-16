//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolGradeOffered Model
     /// </summary>
    public partial class K12SchoolGradeOfferedModel : AutobahnBase, Interfaces.IK12SchoolGradeOffered
    {
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
        public Guid? RefGradeLevelId { get; set; }

    }
}
