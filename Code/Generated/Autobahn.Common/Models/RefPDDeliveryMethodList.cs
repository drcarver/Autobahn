//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDDeliveryMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDDeliveryMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDDeliveryMethod"> List
         /// </summary>
        public static List<RefPDDeliveryMethod> RefPDDeliveryMethodList = new List<RefPDDeliveryMethod>
        {
            new RefPDDeliveryMethod { Id=Guid.Parse("c48d03c5-de50-4dad-940a-66e282cb9e82"), Code="Onsite", Description="Onsite", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("5ada2e1e-0074-40b2-a7ad-b758b8869f43"), Code="Virtual", Description="Virtual classroom", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("2ca76483-1db2-4bde-a83b-13faf448ee56"), Code="Off-Site", Description="Off-site classroom", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("62a7b843-d5ee-4da3-8fb1-05cd031663b1"), Code="Conference", Description="Conference", Definition="", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefPDDeliveryMethod Pick List
         /// </summary>
        public static List<RefPDDeliveryMethod> RefPDDeliveryMethodPickList = new List<RefPDDeliveryMethod>
        {
            new RefPDDeliveryMethod { Id=Guid.Parse("c48d03c5-de50-4dad-940a-66e282cb9e82"), Code="Onsite", Description="Onsite", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("5ada2e1e-0074-40b2-a7ad-b758b8869f43"), Code="Virtual", Description="Virtual classroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("2ca76483-1db2-4bde-a83b-13faf448ee56"), Code="Off-Site", Description="Off-site classroom", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("62a7b843-d5ee-4da3-8fb1-05cd031663b1"), Code="Conference", Description="Conference", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
