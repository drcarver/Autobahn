//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CoreKnowledgeAreaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CoreKnowledgeArea Model
     /// </summary>
    public partial class CoreKnowledgeAreaModel : AutobahnBase, Interfaces.ICoreKnowledgeArea
    {
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
        public Guid? RefCoreKnowledgeAreaId { get; set; }

    }
}
