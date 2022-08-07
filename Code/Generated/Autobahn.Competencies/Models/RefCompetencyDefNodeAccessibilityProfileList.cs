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
        /// The complete <see cref="RefCompetencyDefNodeAccessibilityProfileModel"> List
         /// </summary>
        public static List<RefCompetencyDefNodeAccessibilityProfileModel> RefCompetencyDefNodeAccessibilityProfileList = new List<RefCompetencyDefNodeAccessibilityProfileModel>
        {
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("33f7c457-a91f-4c40-abd2-b98b35a6f025"), Code="Vision", Description="Vision", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired vision.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("b408c6ab-455b-40cd-b3cb-b5bbc78e142f"), Code="Hearing", Description="Hearing", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired hearing.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("ccbd3680-c49f-4433-a86f-c7f4f96bf5a0"), Code="Communication", Description="Communication", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired communication.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("1a657a16-dedd-48ce-b12a-2c1e55d24969"), Code="Mobility", Description="Mobility", Definition="The node in the educational framework is designed to address alternative pathways for learners with impaired mobility.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("0ccd54af-eae8-42e3-8ecf-5ecb2962ba29"), Code="General", Description="General", Definition="The node in the educational framework is designed for a general audience.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefCompetencyDefNodeAccessibilityProfile Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCompetencyDefNodeAccessibilityProfileViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("33f7c457-a91f-4c40-abd2-b98b35a6f025"), Description="Vision", SortOrder=Convert.ToDecimal("2.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("b408c6ab-455b-40cd-b3cb-b5bbc78e142f"), Description="Hearing", SortOrder=Convert.ToDecimal("4.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("ccbd3680-c49f-4433-a86f-c7f4f96bf5a0"), Description="Communication", SortOrder=Convert.ToDecimal("6.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("1a657a16-dedd-48ce-b12a-2c1e55d24969"), Description="Mobility", SortOrder=Convert.ToDecimal("8.00") },
            new RefCompetencyDefNodeAccessibilityProfile { Id=Guid.Parse("0ccd54af-eae8-42e3-8ecf-5ecb2962ba29"), Description="General", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
