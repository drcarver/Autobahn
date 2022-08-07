//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefChildDevelopmentAssociateTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefChildDevelopmentAssociateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefChildDevelopmentAssociateTypeModel"> List
         /// </summary>
        public static List<RefChildDevelopmentAssociateTypeModel> RefChildDevelopmentAssociateTypeList = new List<RefChildDevelopmentAssociateTypeModel>
        {
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("9c1c8c68-d08d-40a4-86cb-f1209696239f"), Code="01", Description="Infant/toddler", Definition="Infant/toddler is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("1.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("47533ea8-6a61-4491-9fe2-f2168987add9"), Code="02", Description="Preschool", Definition="Preschool is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("3.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("0a83ace4-e46c-479e-9172-60a8c57995cf"), Code="03", Description="Family child care home", Definition="Family child care home is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("5.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("f4a64d11-986e-48ff-b2b9-364fa74f97cf"), Code="04", Description="Home visitor", Definition="Home visitor is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("7.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("d4cbf669-6dd5-4b89-a5a8-46355fc3c51c"), Code="06", Description="Other", Definition="Other is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("9.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("ba876ba3-aeab-46f6-84e3-e743b1b5150f"), Code="07", Description="Bilingual", Definition="Bilingual is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("11.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("6cab875b-9c4a-47cb-bb91-3527e91b9e39"), Code="99", Description="No current CDA indicated", Definition="No current CDA indicated is specified as the type of Child Development Associate credential.", SortOrder=Convert.ToDecimal("13.00") },
        };

        /// <summary>
        /// The Reference RefChildDevelopmentAssociateType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefChildDevelopmentAssociateTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("9c1c8c68-d08d-40a4-86cb-f1209696239f"), Description="Infant/toddler", SortOrder=Convert.ToDecimal("1.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("47533ea8-6a61-4491-9fe2-f2168987add9"), Description="Preschool", SortOrder=Convert.ToDecimal("3.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("0a83ace4-e46c-479e-9172-60a8c57995cf"), Description="Family child care home", SortOrder=Convert.ToDecimal("5.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("f4a64d11-986e-48ff-b2b9-364fa74f97cf"), Description="Home visitor", SortOrder=Convert.ToDecimal("7.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("d4cbf669-6dd5-4b89-a5a8-46355fc3c51c"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("ba876ba3-aeab-46f6-84e3-e743b1b5150f"), Description="Bilingual", SortOrder=Convert.ToDecimal("11.00") },
            new RefChildDevelopmentAssociateType { Id=Guid.Parse("6cab875b-9c4a-47cb-bb91-3527e91b9e39"), Description="No current CDA indicated", SortOrder=Convert.ToDecimal("13.00") },
       };
   }
}
