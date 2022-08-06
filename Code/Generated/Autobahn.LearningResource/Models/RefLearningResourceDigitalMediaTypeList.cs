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
        /// The complete <see cref="RefLearningResourceDigitalMediaType"> List
         /// </summary>
        public static List<RefLearningResourceDigitalMediaType> RefLearningResourceDigitalMediaTypeList = new List<RefLearningResourceDigitalMediaType>
        {
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("18e6aa9a-d611-43b5-8373-29b87d8a8c5a"), Code="application", Description="Application", Definition="The AINA registered Media Type of the digital resource is: Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("89f85217-9f9f-495e-8dda-8f6c3cd56d38"), Code="audio", Description="Audio", Definition="The AINA registered Media Type of the digital resource is: Audio", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("8f65fbca-1671-41db-9d8f-6c4374686fbb"), Code="example", Description="Example", Definition="The AINA registered Media Type of the digital resource is: Example", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("8864082f-5e4e-4d5a-ae43-142aadcdd8b3"), Code="image", Description="Image", Definition="The AINA registered Media Type of the digital resource is: Image", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("f31cb00f-ab73-47a9-8881-d77697f48cac"), Code="message", Description="Message", Definition="The AINA registered Media Type of the digital resource is: Message", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("ccde000e-7343-42c7-85c6-5228b0ec7a5b"), Code="model", Description="Model", Definition="The AINA registered Media Type of the digital resource is: Model", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("e56ebecc-de9f-49e6-9a27-6f942d455adf"), Code="multipart", Description="Multipart", Definition="The AINA registered Media Type of the digital resource is: Multipart", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("b329035c-35fa-415b-99c4-f9f3c1ae998c"), Code="text", Description="Text", Definition="The AINA registered Media Type of the digital resource is: Text", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("51ad32ed-fc12-4f93-91f9-9b51391b92c5"), Code="video", Description="Video", Definition="The AINA registered Media Type of the digital resource is: Video", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The RefLearningResourceDigitalMediaType Pick List
         /// </summary>
        public static List<RefLearningResourceDigitalMediaType> RefLearningResourceDigitalMediaTypePickList = new List<RefLearningResourceDigitalMediaType>
        {
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("18e6aa9a-d611-43b5-8373-29b87d8a8c5a"), Code="application", Description="Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("89f85217-9f9f-495e-8dda-8f6c3cd56d38"), Code="audio", Description="Audio", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("8f65fbca-1671-41db-9d8f-6c4374686fbb"), Code="example", Description="Example", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("8864082f-5e4e-4d5a-ae43-142aadcdd8b3"), Code="image", Description="Image", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("f31cb00f-ab73-47a9-8881-d77697f48cac"), Code="message", Description="Message", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("ccde000e-7343-42c7-85c6-5228b0ec7a5b"), Code="model", Description="Model", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("e56ebecc-de9f-49e6-9a27-6f942d455adf"), Code="multipart", Description="Multipart", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("b329035c-35fa-415b-99c4-f9f3c1ae998c"), Code="text", Description="Text", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearningResourceDigitalMediaType { Id=Guid.Parse("51ad32ed-fc12-4f93-91f9-9b51391b92c5"), Code="video", Description="Video", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
