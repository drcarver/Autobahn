//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusCreatorEntityList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRecordStatusCreatorEntity Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRecordStatusCreatorEntityModel"> List
         /// </summary>
        public static List<RefRecordStatusCreatorEntityModel> RefRecordStatusCreatorEntityList = new List<RefRecordStatusCreatorEntityModel>
        {
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("010177eb-caec-4cbd-b50f-eb3facdb6ba5"), Code="Organization", Description="Organization", Definition="An Organization created the Record Status Type.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("4ff93b95-c749-4e78-a86a-83c2b0eb6005"), Code="Person", Description="Person", Definition="A Person created the Record Status Type.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefRecordStatusCreatorEntity Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRecordStatusCreatorEntityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("010177eb-caec-4cbd-b50f-eb3facdb6ba5"), Description="Organization", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusCreatorEntity { Id=Guid.Parse("4ff93b95-c749-4e78-a86a-83c2b0eb6005"), Description="Person", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
