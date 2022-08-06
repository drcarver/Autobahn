//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAInterimRemovalReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAInterimRemovalReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAInterimRemovalReason"> List
         /// </summary>
        public static List<RefIDEAInterimRemovalReason> RefIDEAInterimRemovalReasonList = new List<RefIDEAInterimRemovalReason> =
        {
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("29814553-f5d1-4cd8-8d2c-79e99f1a6476"), Code="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Drugs.", Description="Drugs", Definition="", SortOrder=0 },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("8fd309ed-cdd7-4caa-8f55-eaca62cbffec"), Code="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Weapons.", Description="Weapons", Definition="", SortOrder=0 },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("9226bdca-0e2d-4eb2-88df-a8fbcecb3c5b"), Code="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Serious bodily injury.", Description="SeriousBodilyInjury", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIDEAInterimRemovalReason Pick List
         /// </summary>
        public static List<RefIDEAInterimRemovalReason> RefIDEAInterimRemovalReasonPickList = new List<RefIDEAInterimRemovalReason> =
        {
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("29814553-f5d1-4cd8-8d2c-79e99f1a6476"), Code="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Drugs.", SortOrder=0 },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("8fd309ed-cdd7-4caa-8f55-eaca62cbffec"), Code="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Weapons.", SortOrder=0 },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("9226bdca-0e2d-4eb2-88df-a8fbcecb3c5b"), Code="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Serious bodily injury.", SortOrder=0 },
       };
   }
}
