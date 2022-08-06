//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTechnicalAssistanceDeliveryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTechnicalAssistanceDeliveryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTechnicalAssistanceDeliveryType"> List
         /// </summary>
        public static List<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypeList = new List<RefTechnicalAssistanceDeliveryType>
        {
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("ba01079f-e339-4364-a243-9d67f4cb2c9d"), Code="Onsite", Description="Onsite", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("4929d2db-4338-4ade-91c4-08cecb729d7f"), Code="Virtual", Description="Virtual classroom", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("23a18cb2-66d3-4fd9-b3e1-d5cc62767460"), Code="Off-Site", Description="Off-site classroom", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("3a198f78-4c94-49f0-93aa-e48abdfc0841"), Code="Conference", Description="Conference", Definition="", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefTechnicalAssistanceDeliveryType Pick List
         /// </summary>
        public static List<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypePickList = new List<RefTechnicalAssistanceDeliveryType>
        {
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("ba01079f-e339-4364-a243-9d67f4cb2c9d"), Code="Onsite", Description="Onsite", SortOrder=Convert.ToDecimal("2.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("4929d2db-4338-4ade-91c4-08cecb729d7f"), Code="Virtual", Description="Virtual classroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("23a18cb2-66d3-4fd9-b3e1-d5cc62767460"), Code="Off-Site", Description="Off-site classroom", SortOrder=Convert.ToDecimal("6.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("3a198f78-4c94-49f0-93aa-e48abdfc0841"), Code="Conference", Description="Conference", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
