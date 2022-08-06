//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefELOutcomeMeasurementLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefELOutcomeMeasurementLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELOutcomeMeasurementLevel"> List
         /// </summary>
        public static List<RefELOutcomeMeasurementLevel> RefELOutcomeMeasurementLevelList = new List<RefELOutcomeMeasurementLevel> =
        {
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("59333db3-1ab9-43b5-ac03-bce746a8c271"), Code="Baseline - at entry is the early learning outcome level.", Description="Baseline", Definition="", SortOrder=0 },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("923d0088-ef04-40e5-b483-075d0cd9c26e"), Code="At exit is the early learning outcome level.", Description="AtExit", Definition="", SortOrder=0 },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("b38f284c-f088-4102-b39c-deb67b60f5b3"), Code="No is the early learning outcome level.", Description="No", Definition="", SortOrder=0 },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("db79b032-4400-4a1c-aa17-74dc663781f3"), Code="Other is the early learning outcome level.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefELOutcomeMeasurementLevel Pick List
         /// </summary>
        public static List<RefELOutcomeMeasurementLevel> RefELOutcomeMeasurementLevelPickList = new List<RefELOutcomeMeasurementLevel> =
        {
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("59333db3-1ab9-43b5-ac03-bce746a8c271"), Code="Baseline - at entry is the early learning outcome level.", SortOrder=0 },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("923d0088-ef04-40e5-b483-075d0cd9c26e"), Code="At exit is the early learning outcome level.", SortOrder=0 },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("b38f284c-f088-4102-b39c-deb67b60f5b3"), Code="No is the early learning outcome level.", SortOrder=0 },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("db79b032-4400-4a1c-aa17-74dc663781f3"), Code="Other is the early learning outcome level.", SortOrder=0 },
       };
   }
}
