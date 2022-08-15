//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAddress.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAddress Interface
     /// </summary>
    public partial interface IPersonAddress : IAutobahnBase
    {
        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String ApartmentRoomOrSuiteNumber { get; set; }

    }
}
