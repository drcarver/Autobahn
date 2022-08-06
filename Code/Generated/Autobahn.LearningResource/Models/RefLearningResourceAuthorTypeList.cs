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
        public static List<RefLearningResourceAuthorType> RefLearningResourceAuthorTypeList = new List<RefLearningResourceAuthorType>
        {
            new RefLearningResourceAuthorType { Id=Guid.Parse("97e856fc-694e-4e4e-9d3a-57877258fe4c"), Code="Organization", Description="Organization", Definition="The specified author of the learning resource is an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAuthorType { Id=Guid.Parse("68663237-fb01-4120-b476-ee36a23b1e42"), Code="Person", Description="Person", Definition="The specified author of the learning resource is a person.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefLearningResourceAuthorType Pick List
         /// </summary>
        public static List<RefLearningResourceAuthorType> RefLearningResourceAuthorTypePickList = new List<RefLearningResourceAuthorType>
        {
            new RefLearningResourceAuthorType { Id=Guid.Parse("97e856fc-694e-4e4e-9d3a-57877258fe4c"), Code="Organization", Description="Organization", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAuthorType { Id=Guid.Parse("68663237-fb01-4120-b476-ee36a23b1e42"), Code="Person", Description="Person", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
