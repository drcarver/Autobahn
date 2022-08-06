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
        public static List<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfileList = new List<RefCompetencyDefNodeAccessibilityProfile>
        {
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("388ccf8b-1f14-4e13-bb30-d71a029fb96d"), Code="Vision", Description="Vision", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired vision.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("14ebbb42-8877-4d65-8afc-9d00e929a599"), Code="Hearing", Description="Hearing", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired hearing.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("87665645-b0a7-4440-8773-9107195249a4"), Code="Communication", Description="Communication", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired communication.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("491c1ede-edde-4460-97a3-0fb97c3bd5b4"), Code="Mobility", Description="Mobility", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired mobility.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("88d7cfb1-2feb-4797-8cea-dbf23400d17c"), Code="General", Description="General", Definition="The node in the educational framework is designed for a general audience.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefCompetencyDefNodeAccessibilityProfile Pick List
         /// </summary>
        public static List<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfilePickList = new List<RefCompetencyDefNodeAccessibilityProfile>
        {
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("388ccf8b-1f14-4e13-bb30-d71a029fb96d"), Code="Vision", Description="Vision", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("14ebbb42-8877-4d65-8afc-9d00e929a599"), Code="Hearing", Description="Hearing", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("87665645-b0a7-4440-8773-9107195249a4"), Code="Communication", Description="Communication", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("491c1ede-edde-4460-97a3-0fb97c3bd5b4"), Code="Mobility", Description="Mobility", SortOrder=Convert.ToDecimal("8.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("88d7cfb1-2feb-4797-8cea-dbf23400d17c"), Code="General", Description="General", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
