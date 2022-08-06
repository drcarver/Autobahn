//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELLevelOfSpecializationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELLevelOfSpecialization Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELLevelOfSpecialization"> List
         /// </summary>
        public static List<RefELLevelOfSpecialization> RefELLevelOfSpecializationList = new List<RefELLevelOfSpecialization> =
        {
            new RefELLevelOfSpecialization { Id=Guid.Parse("b5c45988-a335-4f65-b662-ecd1af539358"), Code="The person majored in early learning.", Description="Major", Definition="", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("2d56b900-f9ae-475d-9494-1abb94a9fff0"), Code="The person minored in early learning.", Description="Minor", Definition="", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("b8ab80d7-d24d-4341-8fc2-59eaaa7a4f23"), Code="The person had early learning as an area of emphasis or concentration.", Description="AreaOfEmphasis", Definition="", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("c57d8782-c1f3-4ee7-bca5-4ac3a664bcc8"), Code="Early learning was a focus of post-degree study by the person.", Description="PostDegreeStudy", Definition="", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("bc63e79f-0187-4817-b0fe-d1108b15bd79"), Code="Early learning was as area of Interest for the person.", Description="AreaOfInterest", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefELLevelOfSpecialization Pick List
         /// </summary>
        public static List<RefELLevelOfSpecialization> RefELLevelOfSpecializationPickList = new List<RefELLevelOfSpecialization> =
        {
            new RefELLevelOfSpecialization { Id=Guid.Parse("b5c45988-a335-4f65-b662-ecd1af539358"), Code="The person majored in early learning.", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("2d56b900-f9ae-475d-9494-1abb94a9fff0"), Code="The person minored in early learning.", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("b8ab80d7-d24d-4341-8fc2-59eaaa7a4f23"), Code="The person had early learning as an area of emphasis or concentration.", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("c57d8782-c1f3-4ee7-bca5-4ac3a664bcc8"), Code="Early learning was a focus of post-degree study by the person.", SortOrder=0 },
            new RefELLevelOfSpecialization { Id=Guid.Parse("bc63e79f-0187-4817-b0fe-d1108b15bd79"), Code="Early learning was as area of Interest for the person.", SortOrder=0 },
       };
   }
}
