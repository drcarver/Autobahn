//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefEntryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefEntryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEntryType"> List
         /// </summary>
        public static List<RefEntryType> RefEntryTypeList = new List<RefEntryType> =
        {
            new RefEntryType { Id=Guid.Parse("e821cc91-c34e-430e-89ac-d2832d09f8ea"), Code="Transfer from a public school in the same local education agency is the process by which the student entered a school during a given academic session.", Description="01821", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("fd7f5f04-33a0-4b3a-ae49-c1a9ae128230"), Code="Transfer from a public school in a different local education agency in the same state is the process by which the student entered a school during a given academic session.", Description="01822", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("30a44b88-09b7-44d2-b65e-e31c2d98c83f"), Code="Transfer from a public school in a different state is the process by which the student entered a school during a given academic session.", Description="01823", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("961d624b-affb-4647-a42c-22af8eb42b4a"), Code="Transfer from a private, non-religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", Description="01824", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("51e50aa9-68e6-47df-972d-3cd021a4d9ef"), Code="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", Description="01825", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("2a23732d-fb18-4b2f-aeba-575bc8ed90d7"), Code="Transfer from a private, non-religiously-affiliated school in a different state is the process by which the student entered a school during a given academic session.", Description="01826", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("2bb937a7-8389-4b37-ae3c-c0601464bedd"), Code="Transfer from a private, religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", Description="01827", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("8a4bd94a-8e7e-4de9-b11f-43d7bed61558"), Code="Transfer from a private, religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", Description="01828", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("3a0d9197-fc8e-4285-92fa-54ac4e0e6e74"), Code="Transfer from a private, religiously-affiliated school in a different state", Description="01829", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("89d13e4f-89ad-42b6-9870-2b2847642dd0"), Code="Transfer from a school outside of the country is the process by which the student entered a school during a given academic session.", Description="01830", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("873e9c4e-7767-495b-a9f1-60f94ce8c265"), Code="Transfer from an institution is the process by which the student entered a school during a given academic session.", Description="01831", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("716a5ea6-a4cb-4626-a8b5-0a9ab604f0d6"), Code="Transfer from a charter school is the process by which the student entered a school during a given academic session.", Description="01832", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("a62ab4c8-a870-4bc2-afb1-f28364621979"), Code="Transfer from home schooling is the process by which the student entered a school during a given academic session.", Description="01833", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("58a450f3-17cd-4122-8f99-36afedabc270"), Code="Re-entry from the same school with no interruption of schooling is the process by which the student entered a school during a given academic session.", Description="01835", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("89eab589-907e-4721-9c96-1104c983cfce"), Code="Re-entry after a voluntary withdrawal is the process by which the student entered a school during a given academic session.", Description="01836", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("34f3525e-202b-4e08-8c22-a96566e78d47"), Code="Re-entry after an involuntary withdrawal is the process by which the student entered a school during a given academic session.", Description="01837", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("3206407e-7ae8-4626-933b-8aefcb503aa8"), Code="Original entry into a United States school is the process by which the student entered a school during a given academic session.", Description="01838", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("1f13ebdb-d238-497a-a3af-76b3db6811c2"), Code="Original entry into a United States school from a foreign country with no interruption in schooling is the process by which the student entered a school during a given academic session.", Description="01839", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("b40f8c6b-52c1-4842-9de9-60dcaa05af31"), Code="Original entry into a United States school from a foreign country with an interruption in schooling is the process by which the student entered a school during a given academic session.", Description="01840", Definition="", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("302ac679-063c-49f9-a77b-b4c791f02951"), Code="The process by which the student entered a school during a given academic session is in a category not yet defined in CEDS.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEntryType Pick List
         /// </summary>
        public static List<RefEntryType> RefEntryTypePickList = new List<RefEntryType> =
        {
            new RefEntryType { Id=Guid.Parse("e821cc91-c34e-430e-89ac-d2832d09f8ea"), Code="Transfer from a public school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("fd7f5f04-33a0-4b3a-ae49-c1a9ae128230"), Code="Transfer from a public school in a different local education agency in the same state is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("30a44b88-09b7-44d2-b65e-e31c2d98c83f"), Code="Transfer from a public school in a different state is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("961d624b-affb-4647-a42c-22af8eb42b4a"), Code="Transfer from a private, non-religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("51e50aa9-68e6-47df-972d-3cd021a4d9ef"), Code="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("2a23732d-fb18-4b2f-aeba-575bc8ed90d7"), Code="Transfer from a private, non-religiously-affiliated school in a different state is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("2bb937a7-8389-4b37-ae3c-c0601464bedd"), Code="Transfer from a private, religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("8a4bd94a-8e7e-4de9-b11f-43d7bed61558"), Code="Transfer from a private, religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("3a0d9197-fc8e-4285-92fa-54ac4e0e6e74"), Code="Transfer from a private, religiously-affiliated school in a different state", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("89d13e4f-89ad-42b6-9870-2b2847642dd0"), Code="Transfer from a school outside of the country is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("873e9c4e-7767-495b-a9f1-60f94ce8c265"), Code="Transfer from an institution is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("716a5ea6-a4cb-4626-a8b5-0a9ab604f0d6"), Code="Transfer from a charter school is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("a62ab4c8-a870-4bc2-afb1-f28364621979"), Code="Transfer from home schooling is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("58a450f3-17cd-4122-8f99-36afedabc270"), Code="Re-entry from the same school with no interruption of schooling is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("89eab589-907e-4721-9c96-1104c983cfce"), Code="Re-entry after a voluntary withdrawal is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("34f3525e-202b-4e08-8c22-a96566e78d47"), Code="Re-entry after an involuntary withdrawal is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("3206407e-7ae8-4626-933b-8aefcb503aa8"), Code="Original entry into a United States school is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("1f13ebdb-d238-497a-a3af-76b3db6811c2"), Code="Original entry into a United States school from a foreign country with no interruption in schooling is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("b40f8c6b-52c1-4842-9de9-60dcaa05af31"), Code="Original entry into a United States school from a foreign country with an interruption in schooling is the process by which the student entered a school during a given academic session.", SortOrder=0 },
            new RefEntryType { Id=Guid.Parse("302ac679-063c-49f9-a77b-b4c791f02951"), Code="The process by which the student entered a school during a given academic session is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
