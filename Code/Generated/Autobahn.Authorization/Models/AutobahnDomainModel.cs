//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnDomainModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AutobahnDomain Model
     /// </summary>
    public partial class AutobahnDomainModel : AutobahnBase, Interfaces.IAutobahnDomain
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        public Guid? Id { get; set; }

        public System.String Module { get; set; }

        public System.String Name { get; set; }

    }
}
