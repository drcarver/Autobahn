//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGradeLevelTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGradeLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGradeLevelType"> List
         /// </summary>
        public static List<RefGradeLevelType> RefGradeLevelTypeList = new List<RefGradeLevelType> =
        {
            new RefGradeLevelType { Id=Guid.Parse("18b38a97-cec3-437f-87c5-e60cd2d49852"), Code="", Description="000100", Definition="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("1a8cbbbd-2ece-4483-9547-410af2a4d56d"), Code="", Description="000125", Definition="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("96292415-0740-4481-98cf-8315036b0305"), Code="", Description="000126", Definition="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("52439b16-df2e-473c-8798-d93416d9ed13"), Code="", Description="000131", Definition="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("b21577d5-eee9-40ce-a89d-07694ecbdd2e"), Code="", Description="000177", Definition="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("cc41b8f9-9c76-4ceb-aea1-d878c817ef3c"), Code="", Description="001057", Definition="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("12429f61-7e05-4c29-94a9-c4ecdfef00b9"), Code="", Description="001210", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefGradeLevelType Pick List
         /// </summary>
        public static List<RefGradeLevelType> RefGradeLevelTypePickList = new List<RefGradeLevelType> =
        {
            new RefGradeLevelType { Id=Guid.Parse("18b38a97-cec3-437f-87c5-e60cd2d49852"), Code="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("1a8cbbbd-2ece-4483-9547-410af2a4d56d"), Code="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("96292415-0740-4481-98cf-8315036b0305"), Code="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("52439b16-df2e-473c-8798-d93416d9ed13"), Code="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("b21577d5-eee9-40ce-a89d-07694ecbdd2e"), Code="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("cc41b8f9-9c76-4ceb-aea1-d878c817ef3c"), Code="", SortOrder=0 },
            new RefGradeLevelType { Id=Guid.Parse("12429f61-7e05-4c29-94a9-c4ecdfef00b9"), Code="", SortOrder=0 },
       };
   }
}
