//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionDeliveryModeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseSectionDeliveryMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionDeliveryModeModel"> List
         /// </summary>
        public static List<RefCourseSectionDeliveryModeModel> RefCourseSectionDeliveryModeList = new List<RefCourseSectionDeliveryModeModel>
        {
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("e61e6de4-17c9-42af-a2da-e4af4cf7d64f"), Code="Broadcast", Description="Broadcast", Definition="Course is taught via live or taped broadcast over open air, closed circuit, or cable television systems.", SortOrder=Convert.ToDecimal("0.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("1bd6823c-21ad-4fac-a7ea-835ab684ba3d"), Code="Correspondence", Description="Correspondence", Definition="Course is taught via hard or electronic copy or other media (CD, DVD, video cassette) and student works at own pace usually without an instructor present, but generally under supervision of LEA. Includes \u0022packet\u0022 programs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("1dbdd073-2057-4dbd-b2fb-be6f8fb7e173"), Code="EarlyCollege", Description="Early College", Definition="Course is taught by institution of higher education, but does NOT qualify as concurrent enrollment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("f6ef907b-6763-4899-a36e-9bde24065f74"), Code="AudioVideo", Description="Interactive Audio/Video", Definition="Course is taught via remote interactive receiver or via streaming media technologies.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("649a8419-9cc2-4f0e-a20d-d7679c11e6d3"), Code="Online", Description="Online", Definition="Course is taught through a website, web application, or app on an internet connected device.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("31033c87-0d8c-4f1c-a492-e49c9624ea67"), Code="IndependentStudy", Description="Independent Study", Definition="Structured learning experience is recognized for credit but is not under supervision of the LEA.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("3a7c8aba-a750-4b74-92bc-21f71bc59932"), Code="FaceToFace", Description="Face to Face", Definition="Course is taught primarily in person and usually in a conventional classroom or lecture hall.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("3c2acb53-846c-475d-a87c-076aed0a064c"), Code="BlendedLearning", Description="Blended Learning", Definition="Course uses a blended learning model that includes Face to Face and Online components.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The Reference RefCourseSectionDeliveryMode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseSectionDeliveryModeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("e61e6de4-17c9-42af-a2da-e4af4cf7d64f"), Description="Broadcast", SortOrder=Convert.ToDecimal("0.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("1bd6823c-21ad-4fac-a7ea-835ab684ba3d"), Description="Correspondence", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("1dbdd073-2057-4dbd-b2fb-be6f8fb7e173"), Description="Early College", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("f6ef907b-6763-4899-a36e-9bde24065f74"), Description="Interactive Audio/Video", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("649a8419-9cc2-4f0e-a20d-d7679c11e6d3"), Description="Online", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("31033c87-0d8c-4f1c-a492-e49c9624ea67"), Description="Independent Study", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("3a7c8aba-a750-4b74-92bc-21f71bc59932"), Description="Face to Face", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("3c2acb53-846c-475d-a87c-076aed0a064c"), Description="Blended Learning", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
