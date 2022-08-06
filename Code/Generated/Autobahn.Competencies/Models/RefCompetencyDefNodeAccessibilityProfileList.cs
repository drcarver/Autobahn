//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefCompetencyDefNodeAccessibilityProfileList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefCompetencyDefNodeAccessibilityProfile Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCompetencyDefNodeAccessibilityProfile"> List
         /// </summary>
        public static List<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfileList = new List<RefCompetencyDefNodeAccessibilityProfile> =
        {
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("f1cae615-8b85-4958-9fd7-229933077e80"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired vision.", Description="Vision", Definition="", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("59f0199b-2c71-40bd-93df-85dcac126a48"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired hearing.", Description="Hearing", Definition="", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("b207b231-a141-4867-8d92-e1c722cd3df9"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired communication.", Description="Communication", Definition="", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("1d764b72-2520-4966-9189-2110d185ed57"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired mobility.", Description="Mobility", Definition="", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("6f7e5924-c107-4d06-8b6b-4c1692ef3e9f"), Code="The node in the educational framework is designed for a general audience.", Description="General", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCompetencyDefNodeAccessibilityProfile Pick List
         /// </summary>
        public static List<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfilePickList = new List<RefCompetencyDefNodeAccessibilityProfile> =
        {
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("f1cae615-8b85-4958-9fd7-229933077e80"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired vision.", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("59f0199b-2c71-40bd-93df-85dcac126a48"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired hearing.", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("b207b231-a141-4867-8d92-e1c722cd3df9"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired communication.", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("1d764b72-2520-4966-9189-2110d185ed57"), Code="The node in the educational framework is designed to address alternative pathways for learners with impaired mobility.", SortOrder=0 },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("6f7e5924-c107-4d06-8b6b-4c1692ef3e9f"), Code="The node in the educational framework is designed for a general audience.", SortOrder=0 },
       };
   }
}
