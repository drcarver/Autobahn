//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAccreditationAgencyList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAccreditationAgency Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAccreditationAgencyModel"> List
         /// </summary>
        public static List<RefAccreditationAgencyModel> RefAccreditationAgencyList = new List<RefAccreditationAgencyModel>
        {
            new RefAccreditationAgency { Id=Guid.Parse("44f2c7e3-4d84-4a64-9d9a-0053195b7a96"), Code="NAEYC", Description="National Association for the Education of Young Children", Definition="National Association for the Education of Young Children", SortOrder=Convert.ToDecimal("1.00") },
            new RefAccreditationAgency { Id=Guid.Parse("c0c19074-0a55-465e-acb4-43b1f208c1de"), Code="NECPA", Description="National Early Childhood Program Accreditation", Definition="National Early Childhood Program Accreditation", SortOrder=Convert.ToDecimal("2.00") },
            new RefAccreditationAgency { Id=Guid.Parse("8e5bb8f4-397a-4abb-9cb3-ab0d8cca8fc5"), Code="NAC", Description="National Accreditation Commission", Definition="National Accreditation Commission", SortOrder=Convert.ToDecimal("3.00") },
            new RefAccreditationAgency { Id=Guid.Parse("c3b0248e-d350-4804-b57e-500fb83f4fdc"), Code="COA", Description="Council on Accreditation", Definition="Council on Accreditation", SortOrder=Convert.ToDecimal("4.00") },
            new RefAccreditationAgency { Id=Guid.Parse("b9cf0389-198d-48f5-a570-4f8a20859eda"), Code="NAFCC", Description="National Association for Family Child Care", Definition="National Association for Family Child Care", SortOrder=Convert.ToDecimal("5.00") },
            new RefAccreditationAgency { Id=Guid.Parse("4870d58f-a853-4469-9705-31645d317f47"), Code="SACS", Description="Southern Association of Colleges and Schools", Definition="Southern Association of Colleges and Schools", SortOrder=Convert.ToDecimal("6.00") },
            new RefAccreditationAgency { Id=Guid.Parse("46264d9c-9f9b-4d52-b83f-74889ee6b12c"), Code="NotAccredited", Description="Not accredited", Definition="Not accredited", SortOrder=Convert.ToDecimal("7.00") },
            new RefAccreditationAgency { Id=Guid.Parse("e4616a2b-6a15-4737-bbd0-ee0c4cd7fd97"), Code="Other", Description="Other Accreditation Agency", Definition="Other Accreditation Agency", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefAccreditationAgency Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAccreditationAgencyViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAccreditationAgency { Id=Guid.Parse("44f2c7e3-4d84-4a64-9d9a-0053195b7a96"), Description="National Association for the Education of Young Children", SortOrder=Convert.ToDecimal("1.00") },
            new RefAccreditationAgency { Id=Guid.Parse("c0c19074-0a55-465e-acb4-43b1f208c1de"), Description="National Early Childhood Program Accreditation", SortOrder=Convert.ToDecimal("2.00") },
            new RefAccreditationAgency { Id=Guid.Parse("8e5bb8f4-397a-4abb-9cb3-ab0d8cca8fc5"), Description="National Accreditation Commission", SortOrder=Convert.ToDecimal("3.00") },
            new RefAccreditationAgency { Id=Guid.Parse("c3b0248e-d350-4804-b57e-500fb83f4fdc"), Description="Council on Accreditation", SortOrder=Convert.ToDecimal("4.00") },
            new RefAccreditationAgency { Id=Guid.Parse("b9cf0389-198d-48f5-a570-4f8a20859eda"), Description="National Association for Family Child Care", SortOrder=Convert.ToDecimal("5.00") },
            new RefAccreditationAgency { Id=Guid.Parse("4870d58f-a853-4469-9705-31645d317f47"), Description="Southern Association of Colleges and Schools", SortOrder=Convert.ToDecimal("6.00") },
            new RefAccreditationAgency { Id=Guid.Parse("46264d9c-9f9b-4d52-b83f-74889ee6b12c"), Description="Not accredited", SortOrder=Convert.ToDecimal("7.00") },
            new RefAccreditationAgency { Id=Guid.Parse("e4616a2b-6a15-4737-bbd0-ee0c4cd7fd97"), Description="Other Accreditation Agency", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
