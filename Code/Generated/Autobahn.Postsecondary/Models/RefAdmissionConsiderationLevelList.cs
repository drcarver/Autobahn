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
        public static List<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevelList = new List<RefAdmissionConsiderationLevel> =
        {
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("79b39b7c-6e4f-4397-b8ed-5a4ce59a4b41"), Code="This admission criteria is Required.", Description="Required", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("77041cbf-de3a-4ecc-b346-772ba61745ea"), Code="This admission criteria is Recommended.", Description="Recommended", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("7ab3338c-8e25-4729-92d3-59404b0359dc"), Code="This admission criteria is Neither Required nor Recommended.", Description="NeitherRequiredRecommended", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("ce64fa06-9ede-4c24-bae8-3e7a5b1ad00a"), Code="The consideration level for this admission criteria is unknown.", Description="DontKnow", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAdmissionConsiderationLevel Pick List
         /// </summary>
        public static List<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevelPickList = new List<RefAdmissionConsiderationLevel> =
        {
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("79b39b7c-6e4f-4397-b8ed-5a4ce59a4b41"), Code="This admission criteria is Required.", SortOrder=0 },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("77041cbf-de3a-4ecc-b346-772ba61745ea"), Code="This admission criteria is Recommended.", SortOrder=0 },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("7ab3338c-8e25-4729-92d3-59404b0359dc"), Code="This admission criteria is Neither Required nor Recommended.", SortOrder=0 },
            new RefAdmissionConsiderationLevel { Id=Guid.Parse("ce64fa06-9ede-4c24-bae8-3e7a5b1ad00a"), Code="The consideration level for this admission criteria is unknown.", SortOrder=0 },
       };
   }
}
