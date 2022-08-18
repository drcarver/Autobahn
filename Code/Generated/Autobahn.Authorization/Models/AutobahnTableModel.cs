//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnTableModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AutobahnTable Model
     /// </summary>
    public partial class AutobahnTableModel : AutobahnBase, Interfaces.IAutobahnTable
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAutobahnDomain"/> model
        /// </summary>
        public Guid? AutobahnDomainId { get; set; }

        public System.String ColumnName { get; set; }

        public System.String ColumnType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGlobal"/> model
        /// </summary>
        public Guid GlobalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        public Guid? Id { get; set; }

        public System.String ModuleName { get; set; }

        public System.String TableName { get; set; }

        public System.String Version { get; set; }

    }
}
