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
        public static List<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModeList = new List<RefCourseSectionDeliveryMode> =
        {
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("c322387a-1b2f-4326-a026-cd6967c615ee"), Code="Course is taught via live or taped broadcast over open air, closed circuit, or cable television systems.", Description="Broadcast", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("d2ff8f90-6b54-4338-b4c3-89dcbd7c2244"), Code="Course is taught via hard or electronic copy or other media (CD, DVD, video cassette) and student works at own pace usually without an instructor present, but generally under supervision of LEA. Includes "packet" programs.", Description="Correspondence", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("b0dc398d-e189-48d6-bbd4-80e2bf9fef8b"), Code="Course is taught by institution of higher education, but does NOT qualify as concurrent enrollment.", Description="EarlyCollege", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("4c04d4e6-84f5-42fa-bab7-31b157248c18"), Code="Course is taught via remote interactive receiver or via streaming media technologies.", Description="AudioVideo", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("bf3a0449-84f7-4e8a-a922-08a8678668e7"), Code="Course is taught through a website, web application, or app on an internet connected device.", Description="Online", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("aa53debb-ea69-44c0-b06f-059f76983b87"), Code="Structured learning experience is recognized for credit but is not under supervision of the LEA.", Description="IndependentStudy", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("d11e5431-afa6-4882-aab8-246d81c70768"), Code="Course is taught primarily in person and usually in a conventional classroom or lecture hall.", Description="FaceToFace", Definition="", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("039fc224-0eab-480d-bdfb-5f71944114c8"), Code="Course uses a blended learning model that includes Face to Face and Online components.", Description="BlendedLearning", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseSectionDeliveryMode Pick List
         /// </summary>
        public static List<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModePickList = new List<RefCourseSectionDeliveryMode> =
        {
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("c322387a-1b2f-4326-a026-cd6967c615ee"), Code="Course is taught via live or taped broadcast over open air, closed circuit, or cable television systems.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("d2ff8f90-6b54-4338-b4c3-89dcbd7c2244"), Code="Course is taught via hard or electronic copy or other media (CD, DVD, video cassette) and student works at own pace usually without an instructor present, but generally under supervision of LEA. Includes "packet" programs.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("b0dc398d-e189-48d6-bbd4-80e2bf9fef8b"), Code="Course is taught by institution of higher education, but does NOT qualify as concurrent enrollment.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("4c04d4e6-84f5-42fa-bab7-31b157248c18"), Code="Course is taught via remote interactive receiver or via streaming media technologies.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("bf3a0449-84f7-4e8a-a922-08a8678668e7"), Code="Course is taught through a website, web application, or app on an internet connected device.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("aa53debb-ea69-44c0-b06f-059f76983b87"), Code="Structured learning experience is recognized for credit but is not under supervision of the LEA.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("d11e5431-afa6-4882-aab8-246d81c70768"), Code="Course is taught primarily in person and usually in a conventional classroom or lecture hall.", SortOrder=0 },
            new RefCourseSectionDeliveryMode { Id=Guid.Parse("039fc224-0eab-480d-bdfb-5f71944114c8"), Code="Course uses a blended learning model that includes Face to Face and Online components.", SortOrder=0 },
       };
   }
}
