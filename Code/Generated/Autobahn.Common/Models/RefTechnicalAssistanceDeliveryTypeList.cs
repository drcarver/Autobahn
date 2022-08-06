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
        public static List<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypeList = new List<RefTechnicalAssistanceDeliveryType> =
        {
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("a65d5870-d8c3-4b36-abbc-c0f037198083"), Code="", Description="Onsite", Definition="", SortOrder=0 },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("471d72db-d702-4fb2-8629-5ae20047c081"), Code="", Description="Virtual", Definition="", SortOrder=0 },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("8aaec77f-5bdd-4bf6-afd0-8a6715e12f5e"), Code="", Description="Off-Site", Definition="", SortOrder=0 },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("44164e40-2841-4720-b888-cac834e5aa8f"), Code="", Description="Conference", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTechnicalAssistanceDeliveryType Pick List
         /// </summary>
        public static List<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypePickList = new List<RefTechnicalAssistanceDeliveryType> =
        {
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("a65d5870-d8c3-4b36-abbc-c0f037198083"), Code="", SortOrder=0 },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("471d72db-d702-4fb2-8629-5ae20047c081"), Code="", SortOrder=0 },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("8aaec77f-5bdd-4bf6-afd0-8a6715e12f5e"), Code="", SortOrder=0 },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("44164e40-2841-4720-b888-cac834e5aa8f"), Code="", SortOrder=0 },
       };
   }
}
