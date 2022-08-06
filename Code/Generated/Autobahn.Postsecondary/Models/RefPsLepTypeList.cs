//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsLepTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsLepType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsLepType"> List
         /// </summary>
        public static List<RefPsLepType> RefPsLepTypeList = new List<RefPsLepType> =
        {
            new RefPsLepType { Id=Guid.Parse("554be32d-f813-45f5-9caf-21c97eeb010b"), Code="The person currently meets the standard for limited English proficiency.", Description="Yes", Definition="", SortOrder=0 },
            new RefPsLepType { Id=Guid.Parse("6f73f4d5-3af2-4a7f-9b32-0715b04a9a42"), Code="The person currently does not meet the standard for limited English proficiency.", Description="No", Definition="", SortOrder=0 },
            new RefPsLepType { Id=Guid.Parse("cb763b1f-7c15-4303-a706-fe0eaa51b1b7"), Code="The person currently does not meet the standard for limited English proficiency, but previously did meet the standard for limited English proficiency.", Description="Ever", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPsLepType Pick List
         /// </summary>
        public static List<RefPsLepType> RefPsLepTypePickList = new List<RefPsLepType> =
        {
            new RefPsLepType { Id=Guid.Parse("554be32d-f813-45f5-9caf-21c97eeb010b"), Code="The person currently meets the standard for limited English proficiency.", SortOrder=0 },
            new RefPsLepType { Id=Guid.Parse("6f73f4d5-3af2-4a7f-9b32-0715b04a9a42"), Code="The person currently does not meet the standard for limited English proficiency.", SortOrder=0 },
            new RefPsLepType { Id=Guid.Parse("cb763b1f-7c15-4303-a706-fe0eaa51b1b7"), Code="The person currently does not meet the standard for limited English proficiency, but previously did meet the standard for limited English proficiency.", SortOrder=0 },
       };
   }
}
