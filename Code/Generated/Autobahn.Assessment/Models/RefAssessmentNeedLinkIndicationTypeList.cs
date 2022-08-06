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
        public static List<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypeList = new List<RefAssessmentNeedLinkIndicationType> =
        {
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("411fcb4d-7896-43c6-a05b-e922b4e6c19d"), Code="Speak link is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", Description="SpeakLink", Definition="", SortOrder=0 },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("29c8f778-dfc9-4f9c-91a8-04d44226faa7"), Code="Different voice is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", Description="DifferentVoice", Definition="", SortOrder=0 },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("e30a8a8f-78fa-4160-8863-76a012952d43"), Code="Sound effect is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", Description="SoundEffect", Definition="", SortOrder=0 },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("b15989f6-3d01-480c-bdd8-b97215eabc0a"), Code="None is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", Description="None", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedLinkIndicationType Pick List
         /// </summary>
        public static List<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypePickList = new List<RefAssessmentNeedLinkIndicationType> =
        {
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("411fcb4d-7896-43c6-a05b-e922b4e6c19d"), Code="Speak link is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=0 },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("29c8f778-dfc9-4f9c-91a8-04d44226faa7"), Code="Different voice is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=0 },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("e30a8a8f-78fa-4160-8863-76a012952d43"), Code="Sound effect is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=0 },
            new RefAssessmentNeedLinkIndicationType { Id=Guid.Parse("b15989f6-3d01-480c-bdd8-b97215eabc0a"), Code="None is specified as part of an Assessment Personal Needs Profile as the characteristics of presentation for a hyperlink when using a screen reader.", SortOrder=0 },
       };
   }
}
