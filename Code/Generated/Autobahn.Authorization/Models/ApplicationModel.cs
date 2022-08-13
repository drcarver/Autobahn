//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Application Model
     /// </summary>
    public partial class ApplicationModel : AutobahnBase, Interfaces.IApplication
    {
        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        public System.String Uri { get; set; }

    }
}
