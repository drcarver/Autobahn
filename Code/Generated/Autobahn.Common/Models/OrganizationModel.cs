//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Organization Model
     /// </summary>
    public partial class OrganizationModel : AutobahnBase, Interfaces.IOrganizationModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
