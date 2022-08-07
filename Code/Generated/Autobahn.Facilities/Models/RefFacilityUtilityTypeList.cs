//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityUtilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityUtilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityUtilityTypeModel"> List
         /// </summary>
        public static List<RefFacilityUtilityTypeModel> RefFacilityUtilityTypeList = new List<RefFacilityUtilityTypeModel>
        {
            new RefFacilityUtilityType { Id=Guid.Parse("b5dda928-39b3-440d-9dc0-70372266d93a"), Code="02840", Description="Electricity", Definition="Electricity is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("32fa6b76-1113-4536-8cce-680ed09ed905"), Code="02990", Description="Internet service", Definition="Internet service is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("9fad7922-696f-44af-bc36-cf7c0139d565"), Code="02841", Description="Natural gas", Definition="Natural gas is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("9f72884d-a60c-4346-9edc-8332894ac223"), Code="02842", Description="Oil", Definition="Oil is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("17891a45-c765-4bb4-bf26-5f5d5e9e7978"), Code="13685", Description="Recycling", Definition="Recycling is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("7424a4bd-20bf-497d-8f6d-730d602b4f77"), Code="02844", Description="Sewer", Definition="Sewer is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("83e94e5d-9db0-4dcb-8b59-6c2cc192ad96"), Code="02845", Description="Telephone", Definition="Telephone is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("2b667821-034d-495c-bfc9-1be5ef73c4db"), Code="13686", Description="Waste", Definition="Waste is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("e3bc2e99-368d-4f52-acbe-4993686b3ba5"), Code="02843", Description="Water", Definition="Water is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("dcfb2c7e-094c-476e-9702-577220312db6"), Code="09999", Description="Other", Definition="Other is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityUtilityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityUtilityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityUtilityType { Id=Guid.Parse("b5dda928-39b3-440d-9dc0-70372266d93a"), Description="Electricity", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("32fa6b76-1113-4536-8cce-680ed09ed905"), Description="Internet service", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("9fad7922-696f-44af-bc36-cf7c0139d565"), Description="Natural gas", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("9f72884d-a60c-4346-9edc-8332894ac223"), Description="Oil", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("17891a45-c765-4bb4-bf26-5f5d5e9e7978"), Description="Recycling", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("7424a4bd-20bf-497d-8f6d-730d602b4f77"), Description="Sewer", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("83e94e5d-9db0-4dcb-8b59-6c2cc192ad96"), Description="Telephone", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("2b667821-034d-495c-bfc9-1be5ef73c4db"), Description="Waste", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("e3bc2e99-368d-4f52-acbe-4993686b3ba5"), Description="Water", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("dcfb2c7e-094c-476e-9702-577220312db6"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
