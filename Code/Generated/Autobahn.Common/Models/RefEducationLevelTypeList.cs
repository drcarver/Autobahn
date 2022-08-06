//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationLevelTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEducationLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEducationLevelType"> List
         /// </summary>
        public static List<RefEducationLevelType> RefEducationLevelTypeList = new List<RefEducationLevelType>
        {
            new RefEducationLevelType { Id=Guid.Parse("53e2e156-16b4-4df8-b3f1-c1762afeffab"), Code="000141", Description="Highest Level of Education Completed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("9eeb512f-0c89-44f7-9f66-5658fe7b447a"), Code="000725", Description="Competency Definition Education Level", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("10527461-a02a-43d6-af2c-8330396a5b88"), Code="001229", Description="Maternal Guardian Education", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("4d8a9089-c95f-4864-99fd-8e2b331b162a"), Code="001230", Description="Paternal Guardian Education", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("bc584979-0cdd-4758-9bcf-bc202d9593db"), Code="001246", Description="Learning Resource Education Level�", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefEducationLevelType Pick List
         /// </summary>
        public static List<RefEducationLevelType> RefEducationLevelTypePickList = new List<RefEducationLevelType>
        {
            new RefEducationLevelType { Id=Guid.Parse("53e2e156-16b4-4df8-b3f1-c1762afeffab"), Code="000141", Description="Highest Level of Education Completed", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("9eeb512f-0c89-44f7-9f66-5658fe7b447a"), Code="000725", Description="Competency Definition Education Level", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("10527461-a02a-43d6-af2c-8330396a5b88"), Code="001229", Description="Maternal Guardian Education", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("4d8a9089-c95f-4864-99fd-8e2b331b162a"), Code="001230", Description="Paternal Guardian Education", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("bc584979-0cdd-4758-9bcf-bc202d9593db"), Code="001246", Description="Learning Resource Education Level�", SortOrder=Convert.ToDecimal("") },
       };
   }
}
