//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceDigitalMediaTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceDigitalMediaType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceDigitalMediaTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceDigitalMediaTypeModel> RefLearningResourceDigitalMediaTypeList = new List<RefLearningResourceDigitalMediaTypeModel>
        {
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("1d265893-57a1-4cf3-8af1-ecdf279baa27"), Code="application", Description="Application", Definition="The AINA registered Media Type of the digital resource is: Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("3307ab90-2921-43f8-84f6-c1faa13b8839"), Code="audio", Description="Audio", Definition="The AINA registered Media Type of the digital resource is: Audio", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("e503ff8d-8a55-4641-8769-c5c82b59a446"), Code="example", Description="Example", Definition="The AINA registered Media Type of the digital resource is: Example", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("a71cc767-e97c-495f-9ab0-469639822970"), Code="image", Description="Image", Definition="The AINA registered Media Type of the digital resource is: Image", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("a704b424-256c-4ca3-95d5-71b7833587ab"), Code="message", Description="Message", Definition="The AINA registered Media Type of the digital resource is: Message", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("1a8f2ff0-84ef-4524-9f6c-083e9eeb3679"), Code="model", Description="Model", Definition="The AINA registered Media Type of the digital resource is: Model", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("fb8d3aac-a0e6-4f66-9434-619eec273903"), Code="multipart", Description="Multipart", Definition="The AINA registered Media Type of the digital resource is: Multipart", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("7ead9d4b-f1dd-4dc1-b76b-1dbebacbcff1"), Code="text", Description="Text", Definition="The AINA registered Media Type of the digital resource is: Text", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("618f5a45-75be-443b-a377-4c71f8f0a63a"), Code="video", Description="Video", Definition="The AINA registered Media Type of the digital resource is: Video", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceDigitalMediaType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceDigitalMediaTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("1d265893-57a1-4cf3-8af1-ecdf279baa27"), Description="Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("3307ab90-2921-43f8-84f6-c1faa13b8839"), Description="Audio", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("e503ff8d-8a55-4641-8769-c5c82b59a446"), Description="Example", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("a71cc767-e97c-495f-9ab0-469639822970"), Description="Image", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("a704b424-256c-4ca3-95d5-71b7833587ab"), Description="Message", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("1a8f2ff0-84ef-4524-9f6c-083e9eeb3679"), Description="Model", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("fb8d3aac-a0e6-4f66-9434-619eec273903"), Description="Multipart", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("7ead9d4b-f1dd-4dc1-b76b-1dbebacbcff1"), Description="Text", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("618f5a45-75be-443b-a377-4c71f8f0a63a"), Description="Video", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
