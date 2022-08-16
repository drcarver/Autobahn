//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusion Model
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionModel : AutobahnBase, Interfaces.ITeacherStudentDataLinkExclusion
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid?  { get; set; }

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
