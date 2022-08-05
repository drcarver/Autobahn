//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Role.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Role
     /// </summary>
    public partial class Role : AutobahnBase, Interfaces.IRole
    {
        /// <summary>
        /// Defines the Role.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRole"/> model
        /// </summary>
        public Guid? RefRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
