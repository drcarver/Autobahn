//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   ITeacherStudentDataLinkExclusion.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherStudentDataLinkExclusion Interface
     /// </summary>
    public partial interface ITeacherStudentDataLinkExclusion : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid?  { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
