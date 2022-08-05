//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Organization.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Organization
     /// </summary>
    public partial class Organization : AutobahnBase, Interfaces.IOrganization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
