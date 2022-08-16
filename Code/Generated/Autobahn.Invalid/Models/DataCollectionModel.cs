//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   DataCollectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The DataCollection Model
     /// </summary>
    public partial class DataCollectionModel : AutobahnBase, Interfaces.IDataCollection
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? DataCollectionAcademicSchoolYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DataCollectionCloseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DataCollectionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DataCollectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DataCollectionOpenDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDataCollectionStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SourceSystemName { get; set; }

    }
}
