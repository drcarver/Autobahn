//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceBookFormatTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceBookFormatType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceBookFormatType"> List
         /// </summary>
        public static List<RefLearningResourceBookFormatType> RefLearningResourceBookFormatTypeList = new List<RefLearningResourceBookFormatType>
        {
            new RefLearningResourceBookFormatType { Id=Guid.Parse("ddf0d885-c92d-4afe-a17d-b86f19b76e8e"), Code="Ebook", Description="Ebook", Definition="Ebook is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("229a86bf-e9f1-4b8e-97e0-9d5129e693ef"), Code="Hardcover", Description="Hardcover", Definition="Hardcover is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("20ad2f55-23f7-4068-b1c9-9e51aa8b9ae9"), Code="Paperback", Description="Paperback", Definition="Paperback is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("d65e230f-6499-4254-b9f8-2a7a4a76aace"), Code="DAISY202", Description="DAISY202", Definition="DAISY202 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("f3fae486-a7fc-4748-980f-1d62035cd0dd"), Code="DAISY3", Description="DAISY3", Definition="DAISY3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("a0f2bd5f-81b9-4406-8610-536fa4e12905"), Code="EPUB2", Description="EPUB2", Definition="EPUB2 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("f78e8a35-adda-491a-a5ed-42c677ab6989"), Code="EPUB3", Description="EPUB3", Definition="EPUB3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("5c7a9b0d-0a2a-437b-86d3-6ca9b1a24fd2"), Code="Other", Description="Other", Definition="The specific format for the learning resource that is a book is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("16.00") },
        };

        /// <summary>
        /// The RefLearningResourceBookFormatType Pick List
         /// </summary>
        public static List<RefLearningResourceBookFormatType> RefLearningResourceBookFormatTypePickList = new List<RefLearningResourceBookFormatType>
        {
            new RefLearningResourceBookFormatType { Id=Guid.Parse("ddf0d885-c92d-4afe-a17d-b86f19b76e8e"), Code="Ebook", Description="Ebook", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("229a86bf-e9f1-4b8e-97e0-9d5129e693ef"), Code="Hardcover", Description="Hardcover", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("20ad2f55-23f7-4068-b1c9-9e51aa8b9ae9"), Code="Paperback", Description="Paperback", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("d65e230f-6499-4254-b9f8-2a7a4a76aace"), Code="DAISY202", Description="DAISY202", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("f3fae486-a7fc-4748-980f-1d62035cd0dd"), Code="DAISY3", Description="DAISY3", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("a0f2bd5f-81b9-4406-8610-536fa4e12905"), Code="EPUB2", Description="EPUB2", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("f78e8a35-adda-491a-a5ed-42c677ab6989"), Code="EPUB3", Description="EPUB3", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("5c7a9b0d-0a2a-437b-86d3-6ca9b1a24fd2"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("16.00") },
       };
   }
}
