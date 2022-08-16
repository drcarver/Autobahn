//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPSStudentProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPSStudentProgram Interface
     /// </summary>
    public partial interface IPSStudentProgram : IAutobahnBase
    {
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
         RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefCipUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
