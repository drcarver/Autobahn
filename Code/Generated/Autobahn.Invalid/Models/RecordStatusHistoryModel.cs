//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusHistoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RecordStatusHistory Model
     /// </summary>
    public partial class RecordStatusHistoryModel : AutobahnBase, Interfaces.IRecordStatusHistory
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordStatusDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefRecordStatusTypeId { get; set; }

    }
}
