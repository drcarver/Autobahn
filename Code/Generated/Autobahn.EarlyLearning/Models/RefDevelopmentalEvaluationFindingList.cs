//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefDevelopmentalEvaluationFindingList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefDevelopmentalEvaluationFinding Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDevelopmentalEvaluationFindingModel"> List
         /// </summary>
        public static List<RefDevelopmentalEvaluationFindingModel> RefDevelopmentalEvaluationFindingList = new List<RefDevelopmentalEvaluationFindingModel>
        {
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("82e38d37-95a7-4904-9d3c-520f2992b928"), Code="Adaptive", Description="Adaptive development delay", Definition="Adaptive development delay is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("741f4c54-bc8d-43c3-8ed1-eacb54d494ce"), Code="Cognitive", Description="Cognitive development delay", Definition="Cognitive development delay is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("e1831685-247a-446a-9c47-d80b2a58d14a"), Code="Communication", Description="Communication development delay", Definition="Communication development delay is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("71790aae-838b-4c23-a0b2-4ccf5de5e33c"), Code="NoDelay", Description="No delay, needs follow-up", Definition="No delay, needs follow-up is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("0789e8f5-c1de-482e-acc2-f9df1db8c48c"), Code="None", Description="None", Definition="No finding was determined by the procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("49bc13de-a8f7-4430-ad45-1caccda151cc"), Code="CarnegieUnits", Description="Carnegie Units ", Definition="Carnegie Units is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("1e1e4104-86e7-4399-8258-ebb64303c2d2"), Code="Physical", Description="Physical development delay", Definition="Physical development delay is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("2812838d-6d78-4524-82f0-3f55f85427d9"), Code="SocialEmotional", Description="Social or emotional development delay", Definition="Social or emotional development delay is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("9.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("afb00962-f381-4c1e-9159-4fdec1cdd5c6"), Code="NoDelayDetected", Description="No delay detected", Definition="No child developmental delay/disability was identified by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("6d60f139-52d7-452c-b315-8fecc08d540a"), Code="EstablishedCondition", Description="Established condition", Definition="Established condition is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("11.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("99b8c75e-4302-41cc-ba5b-368e26e0ea43"), Code="AtRisk", Description="At-risk of developing delay", Definition="At-risk of developing delay is the child developmental delay/disability determined by procedure used by appropriate qualified personnel.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefDevelopmentalEvaluationFinding Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDevelopmentalEvaluationFindingViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("82e38d37-95a7-4904-9d3c-520f2992b928"), Description="Adaptive development delay", SortOrder=Convert.ToDecimal("1.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("741f4c54-bc8d-43c3-8ed1-eacb54d494ce"), Description="Cognitive development delay", SortOrder=Convert.ToDecimal("2.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("e1831685-247a-446a-9c47-d80b2a58d14a"), Description="Communication development delay", SortOrder=Convert.ToDecimal("3.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("71790aae-838b-4c23-a0b2-4ccf5de5e33c"), Description="No delay, needs follow-up", SortOrder=Convert.ToDecimal("4.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("0789e8f5-c1de-482e-acc2-f9df1db8c48c"), Description="None", SortOrder=Convert.ToDecimal("6.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("49bc13de-a8f7-4430-ad45-1caccda151cc"), Description="Carnegie Units ", SortOrder=Convert.ToDecimal("7.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("1e1e4104-86e7-4399-8258-ebb64303c2d2"), Description="Physical development delay", SortOrder=Convert.ToDecimal("8.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("2812838d-6d78-4524-82f0-3f55f85427d9"), Description="Social or emotional development delay", SortOrder=Convert.ToDecimal("9.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("afb00962-f381-4c1e-9159-4fdec1cdd5c6"), Description="No delay detected", SortOrder=Convert.ToDecimal("10.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("6d60f139-52d7-452c-b315-8fecc08d540a"), Description="Established condition", SortOrder=Convert.ToDecimal("11.00") },
            new RefDevelopmentalEvaluationFinding { Id=Guid.Parse("99b8c75e-4302-41cc-ba5b-368e26e0ea43"), Description="At-risk of developing delay", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
