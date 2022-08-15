//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddress Model
     /// </summary>
    public partial class PersonAddressModel : AutobahnBase, Interfaces.IPersonAddress
    {
        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get; set; }

    }
}
