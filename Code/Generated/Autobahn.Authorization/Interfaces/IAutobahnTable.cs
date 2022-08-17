//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAutobahnTable.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAutobahnTable Interface
     /// </summary>
    public partial interface IAutobahnTable : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAutobahnDomain"/> model
        /// </summary>
        Guid? AutobahnDomainId { get; set; }

        System.String ColumnName { get; set; }

        System.String ColumnType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGlobal"/> model
        /// </summary>
        Guid GlobalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        Guid? Id { get; set; }

        System.String ModuleName { get; set; }

        System.String TableName { get; set; }

        System.String Version { get; set; }

    }
}
