//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHomelessNighttimeResidenceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefHomelessNighttimeResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHomelessNighttimeResidenceModel"> List
         /// </summary>
        public static List<RefHomelessNighttimeResidenceModel> RefHomelessNighttimeResidenceList = new List<RefHomelessNighttimeResidenceModel>
        {
            new RefHomelessNighttimeResidence { Id=Guid.Parse("8b6c2184-07ff-4118-9cd9-a3310e83dcc3"), Code="DoubledUp", Description="Doubled Up", Definition="Doubled-up (i.e., living with another family) is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("2.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("bfdebb51-5151-4bf6-bbe5-6ba531f597f1"), Code="Unsheltered", Description="Unsheltered", Definition="Unsheltered (e.g. cars, parks, campgrounds, temporary trailers including FEMA trailers, or abandoned buildings) is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("3.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("84a1703f-cd80-4aae-98b7-94f1e071cbd1"), Code="HotelMotel", Description="Hotels/Motels", Definition="Hotels/Motels is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("4.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("6be3cfc3-e16b-453a-89d1-58a2d58e9715"), Code="Shelter", Description="Shelter", Definition="A Shelter is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("5.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("901cd2fd-67fa-4f99-800e-1f1a6bbe13d8"), Code="SheltersTransitionalHousing", Description="Shelters Transitional Housing", Definition="Shelters or Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("6.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("e21d2c7b-7e3c-4a27-abef-569633cf4f0c"), Code="TransitionalHousing", Description="Transitional Housing", Definition="Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefHomelessNighttimeResidence Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefHomelessNighttimeResidenceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefHomelessNighttimeResidence { Id=Guid.Parse("8b6c2184-07ff-4118-9cd9-a3310e83dcc3"), Description="Doubled Up", SortOrder=Convert.ToDecimal("2.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("bfdebb51-5151-4bf6-bbe5-6ba531f597f1"), Description="Unsheltered", SortOrder=Convert.ToDecimal("3.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("84a1703f-cd80-4aae-98b7-94f1e071cbd1"), Description="Hotels/Motels", SortOrder=Convert.ToDecimal("4.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("6be3cfc3-e16b-453a-89d1-58a2d58e9715"), Description="Shelter", SortOrder=Convert.ToDecimal("5.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("901cd2fd-67fa-4f99-800e-1f1a6bbe13d8"), Description="Shelters Transitional Housing", SortOrder=Convert.ToDecimal("6.00") },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("e21d2c7b-7e3c-4a27-abef-569633cf4f0c"), Description="Transitional Housing", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
