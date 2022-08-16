//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IRecordStatusHistory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IRecordStatusHistory Interface
     /// </summary>
    public partial interface IRecordStatusHistory : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordStatusDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefRecordStatusCreatorEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefRecordStatusTypeId { get; set; }

    }
}
