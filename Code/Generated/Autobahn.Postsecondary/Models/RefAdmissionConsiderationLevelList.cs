//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAdmissionConsiderationLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefAdmissionConsiderationLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdmissionConsiderationLevelModel"> List
         /// </summary>
        public static List<RefAdmissionConsiderationLevelModel> RefAdmissionConsiderationLevelList = new List<RefAdmissionConsiderationLevelModel>
        {
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("a39a28a5-81d1-4443-bf62-e5e5cabb1eb8"), Code="Required", Description="Required", Definition="This admission criteria is Required.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("989a4896-9b72-4f7e-a1f1-485125c86703"), Code="Recommended", Description="Recommended", Definition="This admission criteria is Recommended.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("ef8aa061-ccd8-47f5-ba0b-c30309422a5b"), Code="NeitherRequiredRecommended", Description="Neither Required nor Recommended", Definition="This admission criteria is Neither Required nor Recommended.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("8895d62a-f3ab-49f7-a435-74f10cc56a8f"), Code="DontKnow", Description="Don't Know", Definition="The consideration level for this admission criteria is unknown.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefAdmissionConsiderationLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdmissionConsiderationLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("a39a28a5-81d1-4443-bf62-e5e5cabb1eb8"), Description="Required", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("989a4896-9b72-4f7e-a1f1-485125c86703"), Description="Recommended", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("ef8aa061-ccd8-47f5-ba0b-c30309422a5b"), Description="Neither Required nor Recommended", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("8895d62a-f3ab-49f7-a435-74f10cc56a8f"), Description="Don't Know", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
