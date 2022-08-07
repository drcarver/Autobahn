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
        /// The complete <see cref="RefLearningResourceBookFormatTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceBookFormatTypeModel> RefLearningResourceBookFormatTypeList = new List<RefLearningResourceBookFormatTypeModel>
        {
            new RefLearningResourceBookFormatType { Id=Guid.Parse("61887815-ada1-432e-973b-669e90e4d2c5"), Code="Ebook", Description="Ebook", Definition="Ebook is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("f6799dae-061f-4df9-86b1-6af9fe2dd870"), Code="Hardcover", Description="Hardcover", Definition="Hardcover is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("848dda3f-f01b-4cf6-8244-7e236d326fcb"), Code="Paperback", Description="Paperback", Definition="Paperback is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("da8298ce-dc8c-4df6-b36f-60bb0e3e0979"), Code="DAISY202", Description="DAISY202", Definition="DAISY202 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("8ccb8fb3-d919-40af-85eb-f0ec883e851a"), Code="DAISY3", Description="DAISY3", Definition="DAISY3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("b31be728-e41b-404e-a114-979a58d7a504"), Code="EPUB2", Description="EPUB2", Definition="EPUB2 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("41cd4ff9-3e91-43a7-b956-c2f9f42cfe17"), Code="EPUB3", Description="EPUB3", Definition="EPUB3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("adf137fc-c2fb-4177-b669-c5651e9c54ab"), Code="Other", Description="Other", Definition="The specific format for the learning resource that is a book is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("16.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceBookFormatType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceBookFormatTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceBookFormatType { Id=Guid.Parse("61887815-ada1-432e-973b-669e90e4d2c5"), Description="Ebook", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("f6799dae-061f-4df9-86b1-6af9fe2dd870"), Description="Hardcover", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("848dda3f-f01b-4cf6-8244-7e236d326fcb"), Description="Paperback", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("da8298ce-dc8c-4df6-b36f-60bb0e3e0979"), Description="DAISY202", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("8ccb8fb3-d919-40af-85eb-f0ec883e851a"), Description="DAISY3", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("b31be728-e41b-404e-a114-979a58d7a504"), Description="EPUB2", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("41cd4ff9-3e91-43a7-b956-c2f9f42cfe17"), Description="EPUB3", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceBookFormatType { Id=Guid.Parse("adf137fc-c2fb-4177-b669-c5651e9c54ab"), Description="Other", SortOrder=Convert.ToDecimal("16.00") },
       };
   }
}
