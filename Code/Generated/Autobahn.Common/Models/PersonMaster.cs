//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMaster.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonMaster
     /// </summary>
    public partial class PersonMaster : AutobahnBase, Interfaces.IPersonMaster
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
