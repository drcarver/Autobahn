//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAuthorTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAuthorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAuthorType"> List
         /// </summary>
        public static List<RefLearningResourceAuthorType> RefLearningResourceAuthorTypeList = new List<RefLearningResourceAuthorType> =
        {
            new RefLearningResourceAuthorType { Id=Guid.Parse("fb2b014a-9cf4-402a-b741-f54f7dfaad2b"), Code="The specified author of the learning resource is an organization.", Description="Organization", Definition="", SortOrder=0 },
            new RefLearningResourceAuthorType { Id=Guid.Parse("df0b27c9-8770-4040-9e66-483dba1e0fe7"), Code="The specified author of the learning resource is a person.", Description="Person", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceAuthorType Pick List
         /// </summary>
        public static List<RefLearningResourceAuthorType> RefLearningResourceAuthorTypePickList = new List<RefLearningResourceAuthorType> =
        {
            new RefLearningResourceAuthorType { Id=Guid.Parse("fb2b014a-9cf4-402a-b741-f54f7dfaad2b"), Code="The specified author of the learning resource is an organization.", SortOrder=0 },
            new RefLearningResourceAuthorType { Id=Guid.Parse("df0b27c9-8770-4040-9e66-483dba1e0fe7"), Code="The specified author of the learning resource is a person.", SortOrder=0 },
       };
   }
}
