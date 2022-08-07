//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDInstructionalDeliveryModeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDInstructionalDeliveryMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDInstructionalDeliveryModeModel"> List
         /// </summary>
        public static List<RefPDInstructionalDeliveryModeModel> RefPDInstructionalDeliveryModeList = new List<RefPDInstructionalDeliveryModeModel>
        {
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("38e904fb-17e7-4e48-8ffd-17b6ede403b0"), Code="Broadcast", Description="Broadcast", Definition="The primary setting or medium of the professional development delivery is Broadcast.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("8edcdfe9-aed3-4512-b5c0-3dc38e905c3e"), Code="Correspondence", Description="Correspondence", Definition="The primary setting or medium of the professional development delivery is Correspondence.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("c554f5bb-8d6d-43b7-ada3-30c24d3b0fcb"), Code="EarlyCollege", Description="Early College", Definition="The primary setting or medium of the professional development delivery is Early College.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("9ce31a15-8e3b-460d-b993-b81ebe390ba2"), Code="AudioVideo", Description="Interactive Audio/Video", Definition="The primary setting or medium of the professional development delivery is Interactive Audio/Video.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("9088bef5-c9cc-414c-a02f-b67414df0d42"), Code="Conference", Description="Conference", Definition="The primary setting or medium of the professional development delivery is Conference.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("dced8261-1980-45a0-a31a-239e0b4c01fc"), Code="Online", Description="Online", Definition="The primary setting or medium of the professional development delivery is Online.", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("f61ca284-e036-412a-92dd-b2a87aaee716"), Code="IndependentStudy", Description="Independent Study", Definition="The primary setting or medium of the professional development delivery is Independent Study.", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("3cd4594a-e8fb-480c-8005-9b67689e07b4"), Code="FaceToFace", Description="Face To Face", Definition="The primary setting or medium of the professional development delivery is Face To Face.", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("065792d0-98a7-4790-978d-849e53d90568"), Code="BlendedLearning", Description="Blended Learning", Definition="The primary setting or medium of the professional development delivery is Blended Learning.", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("6618c47c-3af3-419f-a35d-eeac115ed5a9"), Code="Other", Description="Other", Definition="The primary setting or medium of the professional development delivery is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The Reference RefPDInstructionalDeliveryMode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDInstructionalDeliveryModeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("38e904fb-17e7-4e48-8ffd-17b6ede403b0"), Description="Broadcast", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("8edcdfe9-aed3-4512-b5c0-3dc38e905c3e"), Description="Correspondence", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("c554f5bb-8d6d-43b7-ada3-30c24d3b0fcb"), Description="Early College", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("9ce31a15-8e3b-460d-b993-b81ebe390ba2"), Description="Interactive Audio/Video", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("9088bef5-c9cc-414c-a02f-b67414df0d42"), Description="Conference", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("dced8261-1980-45a0-a31a-239e0b4c01fc"), Description="Online", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("f61ca284-e036-412a-92dd-b2a87aaee716"), Description="Independent Study", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("3cd4594a-e8fb-480c-8005-9b67689e07b4"), Description="Face To Face", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("065792d0-98a7-4790-978d-849e53d90568"), Description="Blended Learning", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDInstructionalDeliveryMode { Id=Guid.Parse("6618c47c-3af3-419f-a35d-eeac115ed5a9"), Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
