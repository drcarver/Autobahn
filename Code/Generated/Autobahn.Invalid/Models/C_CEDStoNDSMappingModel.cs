//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   C_CEDStoNDSMappingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The C_CEDStoNDSMapping Model
     /// </summary>
    public partial class C_CEDStoNDSMappingModel : AutobahnBase, Interfaces.IC_CEDStoNDSMapping
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String GlobalID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Version { get; set; }

    }
}
