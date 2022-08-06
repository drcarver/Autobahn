//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefMultipleIntelligenceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefMultipleIntelligenceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMultipleIntelligenceType"> List
         /// </summary>
        public static List<RefMultipleIntelligenceType> RefMultipleIntelligenceTypeList = new List<RefMultipleIntelligenceType>
        {
            new RefMultipleIntelligenceType { Id=Guid.Parse("72ab09a1-077a-4e9c-8906-6740c640fcd5"), Code="Linguistic", Description="Linguistic", Definition="The learning standard item or competency fits into the Linguistic intelligence modality. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("0d394461-b3b4-4cd6-9e68-4bab068b501a"), Code="Logic-mathematical", Description="Logic-mathematical", Definition="The learning standard item or competency fits into the Logic-mathematical intelligence modality.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("dc8a4864-c9b3-454e-bc38-8fc5cfb6cd04"), Code="Musical", Description="Musical", Definition="The learning standard item or competency fits into the Musical intelligence modality.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("1fe5518b-da07-435d-907f-8b4760236c26"), Code="Spatial", Description="Spatial", Definition="The learning standard item or competency fits into the Spatial intelligence modality.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("0f496eb8-df8f-41ff-971a-671b0af4fdaa"), Code="BodilyKinesthetic", Description="Bodily/kinesthetic", Definition="The learning standard item or competency fits into the Bodily/kinesthetic intelligence modality.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("cf89335f-78d6-4593-8354-f87257f0675c"), Code="Interpersonal", Description="Interpersonal", Definition="The learning standard item or competency fits into the Interpersonal intelligence modality.", SortOrder=Convert.ToDecimal("6.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("5eb03745-90f8-4fa6-a6b9-7ee50c5dc5dd"), Code="Intrapersonal", Description="Intrapersonal", Definition="The learning standard item or competency fits into the Intrapersonal intelligence modality.", SortOrder=Convert.ToDecimal("7.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("ba3fa47c-dab9-4dbd-b1b8-1978918895c2"), Code="Naturalistic", Description="Naturalistic", Definition="The learning standard item or competency fits into the Naturalistic intelligence modality.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefMultipleIntelligenceType Pick List
         /// </summary>
        public static List<RefMultipleIntelligenceType> RefMultipleIntelligenceTypePickList = new List<RefMultipleIntelligenceType>
        {
            new RefMultipleIntelligenceType { Id=Guid.Parse("72ab09a1-077a-4e9c-8906-6740c640fcd5"), Code="Linguistic", Description="Linguistic", SortOrder=Convert.ToDecimal("1.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("0d394461-b3b4-4cd6-9e68-4bab068b501a"), Code="Logic-mathematical", Description="Logic-mathematical", SortOrder=Convert.ToDecimal("2.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("dc8a4864-c9b3-454e-bc38-8fc5cfb6cd04"), Code="Musical", Description="Musical", SortOrder=Convert.ToDecimal("3.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("1fe5518b-da07-435d-907f-8b4760236c26"), Code="Spatial", Description="Spatial", SortOrder=Convert.ToDecimal("4.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("0f496eb8-df8f-41ff-971a-671b0af4fdaa"), Code="BodilyKinesthetic", Description="Bodily/kinesthetic", SortOrder=Convert.ToDecimal("5.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("cf89335f-78d6-4593-8354-f87257f0675c"), Code="Interpersonal", Description="Interpersonal", SortOrder=Convert.ToDecimal("6.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("5eb03745-90f8-4fa6-a6b9-7ee50c5dc5dd"), Code="Intrapersonal", Description="Intrapersonal", SortOrder=Convert.ToDecimal("7.00") },
            new RefMultipleIntelligenceType { Id=Guid.Parse("ba3fa47c-dab9-4dbd-b1b8-1978918895c2"), Code="Naturalistic", Description="Naturalistic", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
