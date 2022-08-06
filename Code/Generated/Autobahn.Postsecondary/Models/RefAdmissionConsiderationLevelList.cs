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
        /// The complete <see cref="RefAdmissionConsiderationLevel"> List
         /// </summary>
        public static List<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevelList = new List<RefAdmissionConsiderationLevel>
        {
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("93f29312-dbb2-48e9-80b4-f655666635f8"), Code="Required", Description="Required", Definition="This admission criteria is Required.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("b4b76f68-b040-462c-8b53-7b52538a1f1a"), Code="Recommended", Description="Recommended", Definition="This admission criteria is Recommended.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("bb8e8a0f-6f13-4a91-b802-3d252fb614d8"), Code="NeitherRequiredRecommended", Description="Neither Required nor Recommended", Definition="This admission criteria is Neither Required nor Recommended.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("6d8a471d-3ddd-4554-a231-2865b8180176"), Code="DontKnow", Description="Don't Know", Definition="The consideration level for this admission criteria is unknown.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefAdmissionConsiderationLevel Pick List
         /// </summary>
        public static List<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevelPickList = new List<RefAdmissionConsiderationLevel>
        {
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("93f29312-dbb2-48e9-80b4-f655666635f8"), Code="Required", Description="Required", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("b4b76f68-b040-462c-8b53-7b52538a1f1a"), Code="Recommended", Description="Recommended", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("bb8e8a0f-6f13-4a91-b802-3d252fb614d8"), Code="NeitherRequiredRecommended", Description="Neither Required nor Recommended", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("6d8a471d-3ddd-4554-a231-2865b8180176"), Code="DontKnow", Description="Don't Know", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
