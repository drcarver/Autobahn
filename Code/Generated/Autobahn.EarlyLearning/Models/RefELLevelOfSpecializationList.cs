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
        public static List<RefELLevelOfSpecialization> RefELLevelOfSpecializationList = new List<RefELLevelOfSpecialization>
        {
            new RefELLevelOfSpecialization { Id=Guid.Parse("2bd8dcda-60d2-4e61-93ef-5bc8fd680eef"), Code="Major", Description="Major", Definition="The person majored in early learning.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("384146a0-1e91-494c-856c-586e8d2bb465"), Code="Minor", Description="Minor", Definition="The person minored in early learning.", SortOrder=Convert.ToDecimal("2.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("d7b74742-3b5c-4d62-95fe-6874c71d36e4"), Code="AreaOfEmphasis", Description="Area of emphasis or concentration", Definition="The person had early learning as an area of emphasis or concentration.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("76495d57-047a-45f4-af7d-a301dcf6dbd8"), Code="PostDegreeStudy", Description="Post-degree study", Definition="Early learning was a focus of post-degree study by the person.", SortOrder=Convert.ToDecimal("4.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("76a907de-0e8a-4bb7-a50b-2e58b09c3e88"), Code="AreaOfInterest", Description="Area of Interest", Definition="Early learning was as area of Interest for the person.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefELLevelOfSpecialization Pick List
         /// </summary>
        public static List<RefELLevelOfSpecialization> RefELLevelOfSpecializationPickList = new List<RefELLevelOfSpecialization>
        {
            new RefELLevelOfSpecialization { Id=Guid.Parse("2bd8dcda-60d2-4e61-93ef-5bc8fd680eef"), Code="Major", Description="Major", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("384146a0-1e91-494c-856c-586e8d2bb465"), Code="Minor", Description="Minor", SortOrder=Convert.ToDecimal("2.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("d7b74742-3b5c-4d62-95fe-6874c71d36e4"), Code="AreaOfEmphasis", Description="Area of emphasis or concentration", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("76495d57-047a-45f4-af7d-a301dcf6dbd8"), Code="PostDegreeStudy", Description="Post-degree study", SortOrder=Convert.ToDecimal("4.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("76a907de-0e8a-4bb7-a50b-2e58b09c3e88"), Code="AreaOfInterest", Description="Area of Interest", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
