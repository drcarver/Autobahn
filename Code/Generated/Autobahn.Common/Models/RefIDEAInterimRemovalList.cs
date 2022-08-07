//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAInterimRemovalList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAInterimRemoval Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAInterimRemovalModel"> List
         /// </summary>
        public static List<RefIDEAInterimRemovalModel> RefIDEAInterimRemovalList = new List<RefIDEAInterimRemovalModel>
        {
            new RefIDEAInterimRemoval { Id=Guid.Parse("6032eac3-07e4-44c8-a8f6-e4e0b02dceb5"), Code="REMDW", Description="Removal for drugs, weapons, or serious bodily injury", Definition="Unilateral removal to an interim alternative educational setting by School Personnel for drugs, weapons, or serious bodily injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemoval { Id=Guid.Parse("f54fb0d4-a73e-4f0c-8a7b-f07e5cf95bbc"), Code="REMHO", Description="Removed based on a Hearing Officer finding", Definition="Removed to an interim alternative educational setting based on a Hearing Officer finding that there is substantial likelihood of injury to the child or others", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefIDEAInterimRemoval Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEAInterimRemovalViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEAInterimRemoval { Id=Guid.Parse("6032eac3-07e4-44c8-a8f6-e4e0b02dceb5"), Description="Removal for drugs, weapons, or serious bodily injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemoval { Id=Guid.Parse("f54fb0d4-a73e-4f0c-8a7b-f07e5cf95bbc"), Description="Removed based on a Hearing Officer finding", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
