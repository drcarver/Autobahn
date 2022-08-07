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
        /// The complete <see cref="RefELOutcomeMeasurementLevelModel"> List
         /// </summary>
        public static List<RefELOutcomeMeasurementLevelModel> RefELOutcomeMeasurementLevelList = new List<RefELOutcomeMeasurementLevelModel>
        {
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("3721a577-c453-4cfd-944d-c3c6af211c31"), Code="Baseline", Description="Baseline - at entry", Definition="Baseline - at entry is the early learning outcome level.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("9108cbb0-5464-4fde-8f8c-3a68f9717017"), Code="AtExit", Description="At exit", Definition="At exit is the early learning outcome level.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("22c84185-ad18-4b89-a927-9e9d65843e4a"), Code="No", Description="No", Definition="No is the early learning outcome level.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("362a3f4b-b6ae-4d14-aa10-304df3e88615"), Code="Other", Description="Other", Definition="Other is the early learning outcome level.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefELOutcomeMeasurementLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELOutcomeMeasurementLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("3721a577-c453-4cfd-944d-c3c6af211c31"), Description="Baseline - at entry", SortOrder=Convert.ToDecimal("1.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("9108cbb0-5464-4fde-8f8c-3a68f9717017"), Description="At exit", SortOrder=Convert.ToDecimal("3.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("22c84185-ad18-4b89-a927-9e9d65843e4a"), Description="No", SortOrder=Convert.ToDecimal("5.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("362a3f4b-b6ae-4d14-aa10-304df3e88615"), Description="Other", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
