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
        public static List<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveryList = new List<RefMethodOfServiceDelivery>
        {
            new RefMethodOfServiceDelivery { Id=Guid.Parse("5266e83a-93dd-435a-9014-747a8cc5e573"), Code="Individual", Description="Individual", Definition="The services will be provided individually.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMethodOfServiceDelivery { Id=Guid.Parse("b49556e6-627c-4a9a-b920-c17d774ec475"), Code="Group", Description="Group", Definition="The services will be provided in a group.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefMethodOfServiceDelivery Pick List
         /// </summary>
        public static List<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveryPickList = new List<RefMethodOfServiceDelivery>
        {
            new RefMethodOfServiceDelivery { Id=Guid.Parse("5266e83a-93dd-435a-9014-747a8cc5e573"), Code="Individual", Description="Individual", SortOrder=Convert.ToDecimal("2.00") },
            new RefMethodOfServiceDelivery { Id=Guid.Parse("b49556e6-627c-4a9a-b920-c17d774ec475"), Code="Group", Description="Group", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
