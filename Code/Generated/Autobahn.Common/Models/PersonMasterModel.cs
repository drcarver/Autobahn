//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMasterModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonMaster Model
     /// </summary>
    public partial class PersonMasterModel : AutobahnBase, Interfaces.IPersonMasterModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
