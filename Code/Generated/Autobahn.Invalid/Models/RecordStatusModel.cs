//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RecordStatus Model
     /// </summary>
    public partial class RecordStatusModel : AutobahnBase, Interfaces.IRecordStatus
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
