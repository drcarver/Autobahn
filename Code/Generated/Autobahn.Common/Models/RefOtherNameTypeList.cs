//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOtherNameTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOtherNameType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOtherNameType"> List
         /// </summary>
        public static List<RefOtherNameType> RefOtherNameTypeList = new List<RefOtherNameType>
        {
            new RefOtherNameType { Id=Guid.Parse("a1d38895-a0f2-42fe-905e-50dd7e72cce6"), Code="Alias", Description="Alias", Definition="The value specified for Other Name is the person's Alias.", SortOrder=Convert.ToDecimal("1.00") },
            new RefOtherNameType { Id=Guid.Parse("d8f4c91e-4964-4e4d-88a9-5989fe07376c"), Code="Nickname", Description="Nickname", Definition="The value specified for Other Name is the person's Nickname.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOtherNameType { Id=Guid.Parse("86a444c3-edb4-4846-844c-4975a681027a"), Code="OtherName", Description="Other name", Definition="The value specified for Other Name is the person's Other name.", SortOrder=Convert.ToDecimal("3.00") },
            new RefOtherNameType { Id=Guid.Parse("7778ad98-f767-43b4-adb1-53d1011b6f06"), Code="PreviousLegalName", Description="Previous legal name", Definition="The value specified for Other Name is the person's Previous legal name.", SortOrder=Convert.ToDecimal("4.00") },
            new RefOtherNameType { Id=Guid.Parse("b432192f-6260-410f-889f-da2806893087"), Code="PreferredFamilyName", Description="Preferred Family Name", Definition="The value specified for Other Name is the person's Preferred Family Name.", SortOrder=Convert.ToDecimal("6.00") },
            new RefOtherNameType { Id=Guid.Parse("3d8378cb-ac3d-439e-9657-662a87453c56"), Code="PreferredGivenName", Description="Preferred Given Name", Definition="The value specified for Other Name is the person's Preferred Given Name.", SortOrder=Convert.ToDecimal("8.00") },
            new RefOtherNameType { Id=Guid.Parse("a9b78a11-3749-460e-a740-74ae892b83a2"), Code="FullName", Description="Full Name", Definition="The value specified for Other Name is the person's  Full Name.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefOtherNameType Pick List
         /// </summary>
        public static List<RefOtherNameType> RefOtherNameTypePickList = new List<RefOtherNameType>
        {
            new RefOtherNameType { Id=Guid.Parse("a1d38895-a0f2-42fe-905e-50dd7e72cce6"), Code="Alias", Description="Alias", SortOrder=Convert.ToDecimal("1.00") },
            new RefOtherNameType { Id=Guid.Parse("d8f4c91e-4964-4e4d-88a9-5989fe07376c"), Code="Nickname", Description="Nickname", SortOrder=Convert.ToDecimal("2.00") },
            new RefOtherNameType { Id=Guid.Parse("86a444c3-edb4-4846-844c-4975a681027a"), Code="OtherName", Description="Other name", SortOrder=Convert.ToDecimal("3.00") },
            new RefOtherNameType { Id=Guid.Parse("7778ad98-f767-43b4-adb1-53d1011b6f06"), Code="PreviousLegalName", Description="Previous legal name", SortOrder=Convert.ToDecimal("4.00") },
            new RefOtherNameType { Id=Guid.Parse("b432192f-6260-410f-889f-da2806893087"), Code="PreferredFamilyName", Description="Preferred Family Name", SortOrder=Convert.ToDecimal("6.00") },
            new RefOtherNameType { Id=Guid.Parse("3d8378cb-ac3d-439e-9657-662a87453c56"), Code="PreferredGivenName", Description="Preferred Given Name", SortOrder=Convert.ToDecimal("8.00") },
            new RefOtherNameType { Id=Guid.Parse("a9b78a11-3749-460e-a740-74ae892b83a2"), Code="FullName", Description="Full Name", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
