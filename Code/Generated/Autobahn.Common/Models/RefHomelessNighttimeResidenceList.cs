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
        public static List<RefHomelessNighttimeResidence> RefHomelessNighttimeResidenceList = new List<RefHomelessNighttimeResidence> =
        {
            new RefHomelessNighttimeResidence { Id=Guid.Parse("829797ad-83d6-4047-9c63-cb3d53848fb8"), Code="Doubled-up (i.e., living with another family) is the primary nighttime residence of the person at the time they were identified as homeless", Description="DoubledUp", Definition="", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("7dbc7b1a-a8c4-4b95-a0fb-9eeb38b8042f"), Code="Unsheltered (e.g. cars, parks, campgrounds, temporary trailers including FEMA trailers, or abandoned buildings) is the primary nighttime residence of the person at the time they were identified as homeless", Description="Unsheltered", Definition="", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("394eba2f-3cec-4d99-bc4b-2a55912720b6"), Code="Hotels/Motels is the primary nighttime residence of the person at the time they were identified as homeless", Description="HotelMotel", Definition="", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("c3162102-3314-4d02-aa42-3bc4ea6774f7"), Code="A Shelter is the primary nighttime residence of the person at the time they were identified as homeless", Description="Shelter", Definition="", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("d13c4645-17f7-4fa4-9fdc-e66a749f8921"), Code="Shelters or Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", Description="SheltersTransitionalHousing", Definition="", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("66682c7f-742b-4f21-9b83-c30ee552872f"), Code="Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", Description="TransitionalHousing", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefHomelessNighttimeResidence Pick List
         /// </summary>
        public static List<RefHomelessNighttimeResidence> RefHomelessNighttimeResidencePickList = new List<RefHomelessNighttimeResidence> =
        {
            new RefHomelessNighttimeResidence { Id=Guid.Parse("829797ad-83d6-4047-9c63-cb3d53848fb8"), Code="Doubled-up (i.e., living with another family) is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("7dbc7b1a-a8c4-4b95-a0fb-9eeb38b8042f"), Code="Unsheltered (e.g. cars, parks, campgrounds, temporary trailers including FEMA trailers, or abandoned buildings) is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("394eba2f-3cec-4d99-bc4b-2a55912720b6"), Code="Hotels/Motels is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("c3162102-3314-4d02-aa42-3bc4ea6774f7"), Code="A Shelter is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("d13c4645-17f7-4fa4-9fdc-e66a749f8921"), Code="Shelters or Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=0 },
            new RefHomelessNighttimeResidence { Id=Guid.Parse("66682c7f-742b-4f21-9b83-c30ee552872f"), Code="Transitional Housing is the primary nighttime residence of the person at the time they were identified as homeless", SortOrder=0 },
       };
   }
}
