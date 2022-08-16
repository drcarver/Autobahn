//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IAutobahnTable.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IAutobahnTable Interface
     /// </summary>
    public partial interface IAutobahnTable : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AutobahnDomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid GlobalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Version { get; set; }

    }
}
