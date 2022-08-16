//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSectionLocation Model
     /// </summary>
    public partial class PsSectionLocationModel : AutobahnBase, Interfaces.IPsSectionLocation
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? CourseInstructionSiteName { get; set; }

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
        public  RefCourseInstructionSiteTypeId { get; set; }

    }
}
