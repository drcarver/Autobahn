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
        public static List<RefIDEAInterimRemovalReason> RefIDEAInterimRemovalReasonList = new List<RefIDEAInterimRemovalReason>
        {
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("eee4eadb-8f89-4668-a1b0-545e5d253975"), Code="Drugs", Description="Drugs", Definition="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Drugs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("f1bb0b7f-89e4-45e1-8bc1-40392c4c4ae3"), Code="Weapons", Description="Weapons", Definition="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Weapons.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("7dcd30d2-26a0-4213-85f4-80a6afb2ee0c"), Code="SeriousBodilyInjury", Description="Serious bodily injury", Definition="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Serious bodily injury.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefIDEAInterimRemovalReason Pick List
         /// </summary>
        public static List<RefIDEAInterimRemovalReason> RefIDEAInterimRemovalReasonPickList = new List<RefIDEAInterimRemovalReason>
        {
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("eee4eadb-8f89-4668-a1b0-545e5d253975"), Code="Drugs", Description="Drugs", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("f1bb0b7f-89e4-45e1-8bc1-40392c4c4ae3"), Code="Weapons", Description="Weapons", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("7dcd30d2-26a0-4213-85f4-80a6afb2ee0c"), Code="SeriousBodilyInjury", Description="Serious bodily injury", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
