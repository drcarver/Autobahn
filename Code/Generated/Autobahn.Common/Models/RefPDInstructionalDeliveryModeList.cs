//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDInstructionalDeliveryModeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDInstructionalDeliveryMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDInstructionalDeliveryMode"> List
         /// </summary>
        public static List<RefPDInstructionalDeliveryMode> RefPDInstructionalDeliveryModeList = new List<RefPDInstructionalDeliveryMode>
        {
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("52f7e3bc-579f-4929-aba4-1be9a378a2c9"), Code="Broadcast", Description="Broadcast", Definition="The primary setting or medium of the professional development delivery is Broadcast.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("2b3c474f-f0ba-4f7a-b98c-34e375194b69"), Code="Correspondence", Description="Correspondence", Definition="The primary setting or medium of the professional development delivery is Correspondence.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("33d52854-d006-4a2d-9f4d-e9f148af6f71"), Code="EarlyCollege", Description="Early College", Definition="The primary setting or medium of the professional development delivery is Early College.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("0eeea9d6-dcb6-4f46-a22e-50bcda17a503"), Code="AudioVideo", Description="Interactive Audio/Video", Definition="The primary setting or medium of the professional development delivery is Interactive Audio/Video.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("e5f51365-5007-4154-88b1-22e051d56439"), Code="Conference", Description="Conference", Definition="The primary setting or medium of the professional development delivery is Conference.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("1247ceb2-1ba2-459f-8928-9be7fb5deb66"), Code="Online", Description="Online", Definition="The primary setting or medium of the professional development delivery is Online.", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("5252c04c-7a5b-4111-86f5-71269a1ace85"), Code="IndependentStudy", Description="Independent Study", Definition="The primary setting or medium of the professional development delivery is Independent Study.", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("29c790b5-328b-451c-ab66-9e54dcf270a9"), Code="FaceToFace", Description="Face To Face", Definition="The primary setting or medium of the professional development delivery is Face To Face.", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("6df6e8d6-b0e1-4ac5-a0b9-4d154b7fbe91"), Code="BlendedLearning", Description="Blended Learning", Definition="The primary setting or medium of the professional development delivery is Blended Learning.", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("4d63d574-e5ca-442a-8728-4bba75ac9bc3"), Code="Other", Description="Other", Definition="The primary setting or medium of the professional development delivery is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The RefPDInstructionalDeliveryMode Pick List
         /// </summary>
        public static List<RefPDInstructionalDeliveryMode> RefPDInstructionalDeliveryModePickList = new List<RefPDInstructionalDeliveryMode>
        {
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("52f7e3bc-579f-4929-aba4-1be9a378a2c9"), Code="Broadcast", Description="Broadcast", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("2b3c474f-f0ba-4f7a-b98c-34e375194b69"), Code="Correspondence", Description="Correspondence", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("33d52854-d006-4a2d-9f4d-e9f148af6f71"), Code="EarlyCollege", Description="Early College", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("0eeea9d6-dcb6-4f46-a22e-50bcda17a503"), Code="AudioVideo", Description="Interactive Audio/Video", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("e5f51365-5007-4154-88b1-22e051d56439"), Code="Conference", Description="Conference", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("1247ceb2-1ba2-459f-8928-9be7fb5deb66"), Code="Online", Description="Online", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("5252c04c-7a5b-4111-86f5-71269a1ace85"), Code="IndependentStudy", Description="Independent Study", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("29c790b5-328b-451c-ab66-9e54dcf270a9"), Code="FaceToFace", Description="Face To Face", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("6df6e8d6-b0e1-4ac5-a0b9-4d154b7fbe91"), Code="BlendedLearning", Description="Blended Learning", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("4d63d574-e5ca-442a-8728-4bba75ac9bc3"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
