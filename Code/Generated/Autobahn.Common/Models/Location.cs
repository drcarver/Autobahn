//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Location.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Location
     /// </summary>
    public partial class Location : AutobahnBase, Interfaces.ILocation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
