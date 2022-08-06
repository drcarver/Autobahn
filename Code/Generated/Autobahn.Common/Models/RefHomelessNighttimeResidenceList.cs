//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHomelessNighttimeResidenceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefHomelessNighttimeResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHomelessNighttimeResidence"> List
         /// </summary>
        public static List<RefHomelessNighttimeResidence> RefHomelessNighttimeResidenceList = new List<RefHomelessNighttimeResidence>
        {
            new RefHomelessNighttimeResidence { Id=Guid.Parse("812c07fc-e58a-45ef-bb48-7b2128c9acda"), Code="DoubledUp", Description="Doubled Up", Definition="Doubled-up (i.e., living with another family) is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("2.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("9c6262ba-97cb-4cda-9791-fa82ec7a89a5"), Code="Unsheltered", Description="Unsheltered", Definition="Unsheltered (e.g. cars, parks, campgrounds, temporary trailers including FEMA trailers, or abandoned buildings) is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("3.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("ab5712f2-3832-4d2f-83ab-51d5521bcfeb"), Code="HotelMotel", Description="Hotels/Motels", Definition="Hotels/Motels is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("4.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("80e40b9b-1ff5-4c8d-a034-4a82d82b847c"), Code="Shelter", Description="Shelter", Definition="A Shelter is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("5.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("560801e0-493b-459c-ba9e-d47c963a5d1e"), Code="SheltersTransitionalHousing", Description="Shelters Transitional Housing", Definition="Shelters or Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("6.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("7a27d50c-6487-489d-8700-254f5d6231a4"), Code="TransitionalHousing", Description="Transitional Housing", Definition="Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefHomelessNighttimeResidence Pick List
         /// </summary>
        public static List<RefHomelessNighttimeResidence> RefHomelessNighttimeResidencePickList = new List<RefHomelessNighttimeResidence>
        {
            new RefHomelessNighttimeResidence { Id=Guid.Parse("812c07fc-e58a-45ef-bb48-7b2128c9acda"), Code="DoubledUp", Description="Doubled Up", SortOrder=Convert.ToDecimal("2.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("9c6262ba-97cb-4cda-9791-fa82ec7a89a5"), Code="Unsheltered", Description="Unsheltered", SortOrder=Convert.ToDecimal("3.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("ab5712f2-3832-4d2f-83ab-51d5521bcfeb"), Code="HotelMotel", Description="Hotels/Motels", SortOrder=Convert.ToDecimal("4.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("80e40b9b-1ff5-4c8d-a034-4a82d82b847c"), Code="Shelter", Description="Shelter", SortOrder=Convert.ToDecimal("5.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("560801e0-493b-459c-ba9e-d47c963a5d1e"), Code="SheltersTransitionalHousing", Description="Shelters Transitional Housing", SortOrder=Convert.ToDecimal("6.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("7a27d50c-6487-489d-8700-254f5d6231a4"), Code="TransitionalHousing", Description="Transitional Housing", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
