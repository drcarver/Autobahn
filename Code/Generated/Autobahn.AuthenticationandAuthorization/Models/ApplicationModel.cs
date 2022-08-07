//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   ApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AuthenticationandAuthorization.Models
{
     /// <summary>
     /// The Application Model
     /// </summary>
    public partial class ApplicationModel : AutobahnBase, Interfaces.IApplicationModel
    {
        /// <summary>
        /// Defines the Application.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the Application.Uri non nullable property
        /// </summary>
        public System.String Uri { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
