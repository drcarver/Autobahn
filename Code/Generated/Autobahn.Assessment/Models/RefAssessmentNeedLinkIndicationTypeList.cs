//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedLinkIndicationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedLinkIndicationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedLinkIndicationType"> List
         /// </summary>
        public static List<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypeList = new List<RefAssessmentNeedLinkIndicationType>
        {
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("7f49adc5-3733-4bb1-b531-9af3bb88f902"), Code="SpeakLink", Description="Speak link", Definition="Speak link is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("e3ea2593-d265-4a1c-bccc-ebff94d92a5f"), Code="DifferentVoice", Description="Different voice", Definition="Different voice is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("391d239b-4627-43d3-984b-e882d7c3cfc7"), Code="SoundEffect", Description="Sound effect", Definition="Sound effect is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("0f242d61-4c40-433e-af6a-5e674740e861"), Code="None", Description="None", Definition="None is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedLinkIndicationType Pick List
         /// </summary>
        public static List<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypePickList = new List<RefAssessmentNeedLinkIndicationType>
        {
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("7f49adc5-3733-4bb1-b531-9af3bb88f902"), Code="SpeakLink", Description="Speak link", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("e3ea2593-d265-4a1c-bccc-ebff94d92a5f"), Code="DifferentVoice", Description="Different voice", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("391d239b-4627-43d3-984b-e882d7c3cfc7"), Code="SoundEffect", Description="Sound effect", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("0f242d61-4c40-433e-af6a-5e674740e861"), Code="None", Description="None", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
