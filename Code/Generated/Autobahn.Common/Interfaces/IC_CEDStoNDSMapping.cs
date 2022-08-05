//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IC_CEDStoNDSMapping.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IC_CEDStoNDSMapping
     /// </summary>
    public partial interface IC_CEDStoNDSMapping : IAutobahnBase
    {
        /// <summary>
        /// Defines the C_CEDStoNDSMapping.GlobalID non nullable property
        /// </summary>
        System.String GlobalID { get; set; }

        /// <summary>
        /// Defines the C_CEDStoNDSMapping.TableName non nullable property
        /// </summary>
        System.String TableName { get; set; }

        /// <summary>
        /// Defines the C_CEDStoNDSMapping.ColumnName non nullable property
        /// </summary>
        System.String ColumnName { get; set; }

        /// <summary>
        /// Defines the C_CEDStoNDSMapping.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

    }
}
