//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGradeLevelTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGradeLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGradeLevelTypeModel"> List
         /// </summary>
        public static List<RefGradeLevelTypeModel> RefGradeLevelTypeList = new List<RefGradeLevelTypeModel>
        {
            new RefGradeLevelType { Id=Guid.Parse("485dee30-dec2-4d8e-a286-de1e8b130fd2"), Code="000100", Description="Entry Grade Level", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("f17e673d-1ca6-4df2-9198-36a03b09c18d"), Code="000125", Description="Grade Level When Course Taken", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("058e87b7-d086-4508-bafc-ba0119ad71b8"), Code="000126", Description="Grade Level When Assessed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("a3ad4846-b286-4bf9-afe8-f294c038e0b3"), Code="000131", Description="Grades Offered", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("fc81cf1e-f5d6-47eb-b89d-c62cdc4bcfe9"), Code="000177", Description="Assessment Level for Which Designed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("69a20d43-75eb-4bd5-9657-d452c2aa5d94"), Code="001057", Description="Assessment Registration Grade Level to Be Assessed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("0a32c496-3b3d-4b3d-9f2d-dd0a1bc95556"), Code="001210", Description="Exit Grade Level", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefGradeLevelType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGradeLevelTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGradeLevelType { Id=Guid.Parse("485dee30-dec2-4d8e-a286-de1e8b130fd2"), Description="Entry Grade Level", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("f17e673d-1ca6-4df2-9198-36a03b09c18d"), Description="Grade Level When Course Taken", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("058e87b7-d086-4508-bafc-ba0119ad71b8"), Description="Grade Level When Assessed", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("a3ad4846-b286-4bf9-afe8-f294c038e0b3"), Description="Grades Offered", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("fc81cf1e-f5d6-47eb-b89d-c62cdc4bcfe9"), Description="Assessment Level for Which Designed", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("69a20d43-75eb-4bd5-9657-d452c2aa5d94"), Description="Assessment Registration Grade Level to Be Assessed", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("0a32c496-3b3d-4b3d-9f2d-dd0a1bc95556"), Description="Exit Grade Level", SortOrder=Convert.ToDecimal("") },
       };
   }
}
