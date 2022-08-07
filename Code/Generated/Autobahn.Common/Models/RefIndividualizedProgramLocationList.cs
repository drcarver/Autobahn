//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramLocationList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramLocation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramLocationModel"> List
         /// </summary>
        public static List<RefIndividualizedProgramLocationModel> RefIndividualizedProgramLocationList = new List<RefIndividualizedProgramLocationModel>
        {
            new RefIndividualizedProgramLocation { Id=Guid.Parse("8e406955-44eb-40b3-89cf-18c21b976c29"), Code="02192", Description="Home", Definition="Home is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("0.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("d3cb2758-bf9c-4d0c-b6b4-0119775c6929"), Code="00754", Description="Hospital", Definition="Hospital is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("6263eb70-c81a-4c12-97b0-d46774b060b5"), Code="06008", Description="Outpatient hospital", Definition="Outpatient hospital is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("9169053e-2f88-4f91-8366-e7e6c74b3ef5"), Code="06009", Description="Ambulatory care center", Definition="Ambulatory care center is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("d228f413-1bd2-4cbb-b5cb-13acafff787c"), Code="06010", Description="Primary care health provider office", Definition="Primary care health provider office is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("ddc3e5d2-a700-41b0-b568-293725a1ce3f"), Code="01535", Description="Child care", Definition="Child care is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("10.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("2a23d0ba-c075-4320-bf81-ff6490be575c"), Code="00127", Description="Early intervention classroom/center", Definition="Early intervention classroom/center is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("12.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("6a78e733-854c-469e-bd9c-239d883f763c"), Code="00066", Description="Local education agency", Definition="Local education agency is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("14.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("119d0907-9bda-439e-861c-e9d2fabeb374"), Code="06011", Description="Public health facility", Definition="Public health facility is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("16.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("7e847333-1848-4ec6-b98a-4bf19a89e2f8"), Code="06012", Description="Social service agency", Definition="Social service agency is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("18.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("3af35771-7ca5-4485-a6fe-3e537b6d02c4"), Code="06013", Description="Other health care provider location", Definition="Other health care provider location is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("20.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("6630eb92-69fc-4ae2-af8d-d448a8c37b26"), Code="00752", Description="Community facility", Definition="Community facility is the place in which a child's service plan meeting was held.", SortOrder=Convert.ToDecimal("22.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("24eec5ea-d271-4faf-9cf6-dab7fd3b047d"), Code="09999", Description="Other", Definition="The place in which a child's service plan meeting was held is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("24.00") },
        };

        /// <summary>
        /// The Reference RefIndividualizedProgramLocation Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIndividualizedProgramLocationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIndividualizedProgramLocation { Id=Guid.Parse("8e406955-44eb-40b3-89cf-18c21b976c29"), Description="Home", SortOrder=Convert.ToDecimal("0.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("d3cb2758-bf9c-4d0c-b6b4-0119775c6929"), Description="Hospital", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("6263eb70-c81a-4c12-97b0-d46774b060b5"), Description="Outpatient hospital", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("9169053e-2f88-4f91-8366-e7e6c74b3ef5"), Description="Ambulatory care center", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("d228f413-1bd2-4cbb-b5cb-13acafff787c"), Description="Primary care health provider office", SortOrder=Convert.ToDecimal("8.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("ddc3e5d2-a700-41b0-b568-293725a1ce3f"), Description="Child care", SortOrder=Convert.ToDecimal("10.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("2a23d0ba-c075-4320-bf81-ff6490be575c"), Description="Early intervention classroom/center", SortOrder=Convert.ToDecimal("12.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("6a78e733-854c-469e-bd9c-239d883f763c"), Description="Local education agency", SortOrder=Convert.ToDecimal("14.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("119d0907-9bda-439e-861c-e9d2fabeb374"), Description="Public health facility", SortOrder=Convert.ToDecimal("16.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("7e847333-1848-4ec6-b98a-4bf19a89e2f8"), Description="Social service agency", SortOrder=Convert.ToDecimal("18.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("3af35771-7ca5-4485-a6fe-3e537b6d02c4"), Description="Other health care provider location", SortOrder=Convert.ToDecimal("20.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("6630eb92-69fc-4ae2-af8d-d448a8c37b26"), Description="Community facility", SortOrder=Convert.ToDecimal("22.00") },
            new RefIndividualizedProgramLocation { Id=Guid.Parse("24eec5ea-d271-4faf-9cf6-dab7fd3b047d"), Description="Other", SortOrder=Convert.ToDecimal("24.00") },
       };
   }
}
