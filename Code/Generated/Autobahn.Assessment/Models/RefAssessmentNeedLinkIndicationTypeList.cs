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
        /// The complete <see cref="RefAssessmentNeedLinkIndicationTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedLinkIndicationTypeModel> RefAssessmentNeedLinkIndicationTypeList = new List<RefAssessmentNeedLinkIndicationTypeModel>
        {
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("fe2ab978-777d-486f-8311-94fd18b17390"), Code="SpeakLink", Description="Speak link", Definition="Speak link is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("ac7cde8f-7828-4f9c-884b-a75aba1045c8"), Code="DifferentVoice", Description="Different voice", Definition="Different voice is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("e78c0090-ab92-49bd-9441-1ba0be120ae8"), Code="SoundEffect", Description="Sound effect", Definition="Sound effect is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("158be22e-5bca-495d-839a-366c0b7acae8"), Code="None", Description="None", Definition="None is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedLinkIndicationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedLinkIndicationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("fe2ab978-777d-486f-8311-94fd18b17390"), Description="Speak link", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("ac7cde8f-7828-4f9c-884b-a75aba1045c8"), Description="Different voice", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("e78c0090-ab92-49bd-9441-1ba0be120ae8"), Description="Sound effect", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("158be22e-5bca-495d-839a-366c0b7acae8"), Description="None", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
