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
        /// The complete <see cref="RefFacilityUtilityType"> List
         /// </summary>
        public static List<RefFacilityUtilityType> RefFacilityUtilityTypeList = new List<RefFacilityUtilityType>
        {
            new RefFacilityUtilityType { Id=Guid.Parse("f79ad095-607b-4baa-a8d2-dc6a6b6d2bc6"), Code="02840", Description="Electricity", Definition="Electricity is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("3c066eb0-eac3-4371-9046-9fb21e541f00"), Code="02990", Description="Internet service", Definition="Internet service is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("44e945ad-0e3a-46d2-a1a3-a8b786ecc812"), Code="02841", Description="Natural gas", Definition="Natural gas is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("2d0b784f-7e6b-4f7f-9948-eaf24f663534"), Code="02842", Description="Oil", Definition="Oil is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("c47b8a71-e62f-438e-a183-dcc147e8535d"), Code="13685", Description="Recycling", Definition="Recycling is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("09f5b874-d4fe-4049-ae90-2630f9929c23"), Code="02844", Description="Sewer", Definition="Sewer is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("b70b6953-19ab-481f-a70b-129b7994a3e5"), Code="02845", Description="Telephone", Definition="Telephone is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("e4585006-3e98-4d21-917b-7933ba10bb42"), Code="13686", Description="Waste", Definition="Waste is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("71f5f13d-7c82-4e54-b944-06cd66b9ab34"), Code="02843", Description="Water", Definition="Water is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("7347064e-5b7d-451c-936a-23b9f9104c93"), Code="09999", Description="Other", Definition="Other is specified as the type of utility used in the operation of a facility.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityUtilityType Pick List
         /// </summary>
        public static List<RefFacilityUtilityType> RefFacilityUtilityTypePickList = new List<RefFacilityUtilityType>
        {
            new RefFacilityUtilityType { Id=Guid.Parse("f79ad095-607b-4baa-a8d2-dc6a6b6d2bc6"), Code="02840", Description="Electricity", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("3c066eb0-eac3-4371-9046-9fb21e541f00"), Code="02990", Description="Internet service", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("44e945ad-0e3a-46d2-a1a3-a8b786ecc812"), Code="02841", Description="Natural gas", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("2d0b784f-7e6b-4f7f-9948-eaf24f663534"), Code="02842", Description="Oil", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("c47b8a71-e62f-438e-a183-dcc147e8535d"), Code="13685", Description="Recycling", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("09f5b874-d4fe-4049-ae90-2630f9929c23"), Code="02844", Description="Sewer", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("b70b6953-19ab-481f-a70b-129b7994a3e5"), Code="02845", Description="Telephone", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("e4585006-3e98-4d21-917b-7933ba10bb42"), Code="13686", Description="Waste", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("71f5f13d-7c82-4e54-b944-06cd66b9ab34"), Code="02843", Description="Water", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityUtilityType { Id=Guid.Parse("7347064e-5b7d-451c-936a-23b9f9104c93"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
