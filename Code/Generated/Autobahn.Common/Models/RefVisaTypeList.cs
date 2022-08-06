//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefVisaTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefVisaType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefVisaType"> List
         /// </summary>
        public static List<RefVisaType> RefVisaTypeList = new List<RefVisaType> =
        {
            new RefVisaType { Id=Guid.Parse("9ed37125-d89e-415a-9e03-388b43ef96e5"), Code="The non-US citizen's Visa type is Foreign Student Visa.", Description="F1", Definition="", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("11c9db93-b168-4788-b177-ebb342e7337a"), Code="The non-US citizen's Visa type is Foreign Student pursuing vocational or non-academic studies Visa.", Description="M1", Definition="", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("8c202075-d7c2-4432-9abe-4a6c66bbf6d9"), Code="The non-US citizen's Visa type is Employment Visa.", Description="H1", Definition="", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("39593340-4c97-4bec-ad5f-a98f6c986169"), Code="The non-US citizen's Visa type is Business Visa.", Description="B1", Definition="", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("7b9d2348-16ff-48a2-a255-89ad0662126e"), Code="The non-US citizen's Visa type is Tourist Visa.", Description="B2", Definition="", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("b106459e-4565-4566-a022-b00ac8468bfa"), Code="The non-US citizen's Visa type is Exchange Scholar Visa.", Description="J1", Definition="", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("4a8f57ed-6017-4364-935f-b39ecb4d3b4f"), Code="The non-US citizen's Visa type is Other Visa.", Description="OV", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefVisaType Pick List
         /// </summary>
        public static List<RefVisaType> RefVisaTypePickList = new List<RefVisaType> =
        {
            new RefVisaType { Id=Guid.Parse("9ed37125-d89e-415a-9e03-388b43ef96e5"), Code="The non-US citizen's Visa type is Foreign Student Visa.", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("11c9db93-b168-4788-b177-ebb342e7337a"), Code="The non-US citizen's Visa type is Foreign Student pursuing vocational or non-academic studies Visa.", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("8c202075-d7c2-4432-9abe-4a6c66bbf6d9"), Code="The non-US citizen's Visa type is Employment Visa.", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("39593340-4c97-4bec-ad5f-a98f6c986169"), Code="The non-US citizen's Visa type is Business Visa.", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("7b9d2348-16ff-48a2-a255-89ad0662126e"), Code="The non-US citizen's Visa type is Tourist Visa.", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("b106459e-4565-4566-a022-b00ac8468bfa"), Code="The non-US citizen's Visa type is Exchange Scholar Visa.", SortOrder=0 },
            new RefVisaType { Id=Guid.Parse("4a8f57ed-6017-4364-935f-b39ecb4d3b4f"), Code="The non-US citizen's Visa type is Other Visa.", SortOrder=0 },
       };
   }
}
