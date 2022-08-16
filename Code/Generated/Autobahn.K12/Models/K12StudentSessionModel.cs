//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentSession Model
     /// </summary>
    public partial class K12StudentSessionModel : AutobahnBase, Interfaces.IK12StudentSession
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? GradePointAverageGivenSession { get; set; }

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
