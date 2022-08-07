//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   LocationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Location Model
     /// </summary>
    public partial class LocationModel : AutobahnBase, Interfaces.ILocationModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
