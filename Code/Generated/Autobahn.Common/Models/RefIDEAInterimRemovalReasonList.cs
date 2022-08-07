//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAInterimRemovalReasonList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAInterimRemovalReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAInterimRemovalReasonModel"> List
         /// </summary>
        public static List<RefIDEAInterimRemovalReasonModel> RefIDEAInterimRemovalReasonList = new List<RefIDEAInterimRemovalReasonModel>
        {
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("8ee26949-3159-482a-bc94-471d0fda0ec9"), Code="Drugs", Description="Drugs", Definition="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Drugs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("51f92868-3ac1-4091-a42b-fc1167e559b3"), Code="Weapons", Description="Weapons", Definition="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Weapons.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("2211c218-54d2-4c61-9b6a-b43e33b716c1"), Code="SeriousBodilyInjury", Description="Serious bodily injury", Definition="The reason why the child with disabilities was unilaterally removed from the current educational placement to an interim alternative educational setting is related to Serious bodily injury.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefIDEAInterimRemovalReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEAInterimRemovalReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("8ee26949-3159-482a-bc94-471d0fda0ec9"), Description="Drugs", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("51f92868-3ac1-4091-a42b-fc1167e559b3"), Description="Weapons", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAInterimRemovalReason { Id=Guid.Parse("2211c218-54d2-4c61-9b6a-b43e33b716c1"), Description="Serious bodily injury", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
