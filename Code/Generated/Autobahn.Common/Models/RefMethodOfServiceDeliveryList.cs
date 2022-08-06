//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMethodOfServiceDeliveryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMethodOfServiceDelivery Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMethodOfServiceDelivery"> List
         /// </summary>
        public static List<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveryList = new List<RefMethodOfServiceDelivery> =
        {
            new RefMethodOfServiceDelivery { Id=Guid.Parse("ed9b6e10-b14c-43ba-bf02-77472c27382e"), Code="The services will be provided individually.", Description="Individual", Definition="", SortOrder=0 },
            new RefMethodOfServiceDelivery { Id=Guid.Parse("7fc238ed-54fd-4a1d-b114-c5e08e27a3ce"), Code="The services will be provided in a group.", Description="Group", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMethodOfServiceDelivery Pick List
         /// </summary>
        public static List<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveryPickList = new List<RefMethodOfServiceDelivery> =
        {
            new RefMethodOfServiceDelivery { Id=Guid.Parse("ed9b6e10-b14c-43ba-bf02-77472c27382e"), Code="The services will be provided individually.", SortOrder=0 },
            new RefMethodOfServiceDelivery { Id=Guid.Parse("7fc238ed-54fd-4a1d-b114-c5e08e27a3ce"), Code="The services will be provided in a group.", SortOrder=0 },
       };
   }
}
