//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentAcademicHonor Model
     /// </summary>
    public partial class K12StudentAcademicHonorModel : AutobahnBase, Interfaces.IK12StudentAcademicHonor
    {
        /// <summary>
        /// 
        /// </summary>
        public  HonorDescription { get; set; }

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
        public Guid? RefAcademicHonorTypeId { get; set; }

    }
}
