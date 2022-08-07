//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person Model
     /// </summary>
    public partial class PersonModel : AutobahnBase, Interfaces.IPersonModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMaster"/> model
        /// </summary>
        public Guid? PersonMasterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
