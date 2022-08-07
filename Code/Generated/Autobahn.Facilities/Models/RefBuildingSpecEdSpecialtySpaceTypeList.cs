//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingSpecEdSpecialtySpaceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingSpecEdSpecialtySpaceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingSpecEdSpecialtySpaceTypeModel"> List
         /// </summary>
        public static List<RefBuildingSpecEdSpecialtySpaceTypeModel> RefBuildingSpecEdSpecialtySpaceTypeList = new List<RefBuildingSpecEdSpecialtySpaceTypeModel>
        {
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("70cc28f5-ff00-4d59-bb63-50e072089e6a"), Code="02674", Description="IEP conference room", Definition="IEP conference room is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("86217cac-99ef-47f0-91a5-b562949c6565"), Code="02675", Description="Itinerant staff room", Definition="Itinerant staff room is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("70114873-8f7c-4d0e-a16a-f7e736f4f84d"), Code="02671", Description="Occupational therapy room", Definition="Occupational therapy room is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("02ee49f0-f516-4e71-936c-3b2a6ee88ca5"), Code="02673", Description="Physical therapy room", Definition="Physical therapy room is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("f3af1a0c-d08a-4f42-a4f4-3b25dc755e78"), Code="03107", Description="Resource room", Definition="Resource room is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("64d4e7db-d02f-44e9-a312-d9c24ad22a6f"), Code="02676", Description="Self-contained classroom", Definition="Self-contained classroom is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("1eceb1f9-746d-4e18-8330-f65acf804680"), Code="02672", Description="Speech and hearing room", Definition="Speech and hearing room is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("5bfd9214-fcb7-49f4-b596-13f0a3fcc2a9"), Code="09999", Description="Other", Definition="Other is specified as the space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingSpecEdSpecialtySpaceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingSpecEdSpecialtySpaceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("70cc28f5-ff00-4d59-bb63-50e072089e6a"), Description="IEP conference room", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("86217cac-99ef-47f0-91a5-b562949c6565"), Description="Itinerant staff room", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("70114873-8f7c-4d0e-a16a-f7e736f4f84d"), Description="Occupational therapy room", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("02ee49f0-f516-4e71-936c-3b2a6ee88ca5"), Description="Physical therapy room", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("f3af1a0c-d08a-4f42-a4f4-3b25dc755e78"), Description="Resource room", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("64d4e7db-d02f-44e9-a312-d9c24ad22a6f"), Description="Self-contained classroom", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("1eceb1f9-746d-4e18-8330-f65acf804680"), Description="Speech and hearing room", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSpecEdSpecialtySpaceType { Id=Guid.Parse("5bfd9214-fcb7-49f4-b596-13f0a3fcc2a9"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
