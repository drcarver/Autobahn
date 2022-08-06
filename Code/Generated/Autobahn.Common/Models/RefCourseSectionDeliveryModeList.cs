//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionDeliveryModeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseSectionDeliveryMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionDeliveryMode"> List
         /// </summary>
        public static List<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModeList = new List<RefCourseSectionDeliveryMode>
        {
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("6a987d42-d5c9-4304-a1d1-73f2f60162ee"), Code="Broadcast", Description="Broadcast", Definition="Course is taught via live or taped broadcast over open air, closed circuit, or cable television systems.", SortOrder=Convert.ToDecimal("0.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("087929bb-9eab-4106-9df5-9f5bfa02aa48"), Code="Correspondence", Description="Correspondence", Definition="Course is taught via hard or electronic copy or other media (CD, DVD, video cassette) and student works at own pace usually without an instructor present, but generally under supervision of LEA. Includes \u0022packet\u0022 programs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("153fe034-8e68-4cca-b60b-7cb46b83c6d2"), Code="EarlyCollege", Description="Early College", Definition="Course is taught by institution of higher education, but does NOT qualify as concurrent enrollment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("85115758-8b5d-4487-952a-101edfe0006e"), Code="AudioVideo", Description="Interactive Audio/Video", Definition="Course is taught via remote interactive receiver or via streaming media technologies.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("c8a44bfb-5e7e-4974-9742-9e31534dec59"), Code="Online", Description="Online", Definition="Course is taught through a website, web application, or app on an internet connected device.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("7ba25e37-b0de-4c64-ba64-2628bfa83284"), Code="IndependentStudy", Description="Independent Study", Definition="Structured learning experience is recognized for credit but is not under supervision of the LEA.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("a319b20d-0a4f-404c-bcce-971ba13a9896"), Code="FaceToFace", Description="Face to Face", Definition="Course is taught primarily in person and usually in a conventional classroom or lecture hall.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("c63eccbf-5c75-45c1-a54e-fff8936a01e8"), Code="BlendedLearning", Description="Blended Learning", Definition="Course uses a blended learning model that includes Face to Face and Online components.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The RefCourseSectionDeliveryMode Pick List
         /// </summary>
        public static List<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModePickList = new List<RefCourseSectionDeliveryMode>
        {
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("6a987d42-d5c9-4304-a1d1-73f2f60162ee"), Code="Broadcast", Description="Broadcast", SortOrder=Convert.ToDecimal("0.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("087929bb-9eab-4106-9df5-9f5bfa02aa48"), Code="Correspondence", Description="Correspondence", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("153fe034-8e68-4cca-b60b-7cb46b83c6d2"), Code="EarlyCollege", Description="Early College", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("85115758-8b5d-4487-952a-101edfe0006e"), Code="AudioVideo", Description="Interactive Audio/Video", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("c8a44bfb-5e7e-4974-9742-9e31534dec59"), Code="Online", Description="Online", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("7ba25e37-b0de-4c64-ba64-2628bfa83284"), Code="IndependentStudy", Description="Independent Study", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("a319b20d-0a4f-404c-bcce-971ba13a9896"), Code="FaceToFace", Description="Face to Face", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("c63eccbf-5c75-45c1-a54e-fff8936a01e8"), Code="BlendedLearning", Description="Blended Learning", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
