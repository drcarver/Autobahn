//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   C_CEDStoNDSMapping.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The C_CEDStoNDSMapping
     /// </summary>
    public partial class C_CEDStoNDSMapping : AutobahnBase, Interfaces.IC_CEDStoNDSMapping
    {
        /// <summary>
        /// Defines the C_CEDStoNDSMapping.GlobalID non nullable property
        /// </summary>
        public System.String GlobalID { get; set; }

        /// <summary>
        /// Defines the C_CEDStoNDSMapping.TableName non nullable property
        /// </summary>
        public System.String TableName { get; set; }

        /// <summary>
        /// Defines the C_CEDStoNDSMapping.ColumnName non nullable property
        /// </summary>
        public System.String ColumnName { get; set; }

        /// <summary>
        /// Defines the C_CEDStoNDSMapping.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

    }
}
