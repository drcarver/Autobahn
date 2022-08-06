//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefChildDevelopmentAssociateTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefChildDevelopmentAssociateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefChildDevelopmentAssociateType"> List
         /// </summary>
        public static List<RefChildDevelopmentAssociateType> RefChildDevelopmentAssociateTypeList = new List<RefChildDevelopmentAssociateType>
        {
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("7e889fd7-1058-4c40-913f-8f97a53988e7"), Code="01", Description="Infant/toddler", Definition="Infant/toddler is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("1.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("eaeaaa85-793b-4651-825f-41844e3286de"), Code="02", Description="Preschool", Definition="Preschool is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("3.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("b73afa4e-0d02-4403-b472-cafd679f9a0f"), Code="03", Description="Family child care home", Definition="Family child care home is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("5.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("8a8cc3bc-d9cd-40b3-8ca2-6a0685e91463"), Code="04", Description="Home visitor", Definition="Home visitor is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("7.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("96a2ee4c-2394-49fd-adf2-525cbcd65646"), Code="06", Description="Other", Definition="Other is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("9.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("02b44b85-fd4a-44cd-a0a6-fe0f881c2ddc"), Code="07", Description="Bilingual", Definition="Bilingual is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("11.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("b055ef85-fa15-4f18-bce4-2ad44e1d6765"), Code="99", Description="No current CDA indicated", Definition="No current CDA indicated is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("13.00") },
        };

        /// <summary>
        /// The RefChildDevelopmentAssociateType Pick List
         /// </summary>
        public static List<RefChildDevelopmentAssociateType> RefChildDevelopmentAssociateTypePickList = new List<RefChildDevelopmentAssociateType>
        {
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("7e889fd7-1058-4c40-913f-8f97a53988e7"), Code="01", Description="Infant/toddler", SortOrder=Convert.ToDecimal("1.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("eaeaaa85-793b-4651-825f-41844e3286de"), Code="02", Description="Preschool", SortOrder=Convert.ToDecimal("3.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("b73afa4e-0d02-4403-b472-cafd679f9a0f"), Code="03", Description="Family child care home", SortOrder=Convert.ToDecimal("5.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("8a8cc3bc-d9cd-40b3-8ca2-6a0685e91463"), Code="04", Description="Home visitor", SortOrder=Convert.ToDecimal("7.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("96a2ee4c-2394-49fd-adf2-525cbcd65646"), Code="06", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("02b44b85-fd4a-44cd-a0a6-fe0f881c2ddc"), Code="07", Description="Bilingual", SortOrder=Convert.ToDecimal("11.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("b055ef85-fa15-4f18-bce4-2ad44e1d6765"), Code="99", Description="No current CDA indicated", SortOrder=Convert.ToDecimal("13.00") },
       };
   }
}
