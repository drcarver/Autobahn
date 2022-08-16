//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ICourseSectionLocation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ICourseSectionLocation Interface
     /// </summary>
    public partial interface ICourseSectionLocation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ClassroomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInstructionLocationTypeId { get; set; }

    }
}
