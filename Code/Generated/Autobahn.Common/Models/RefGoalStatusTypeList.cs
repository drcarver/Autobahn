//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGoalStatusTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGoalStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGoalStatusTypeModel"> List
         /// </summary>
        public static List<RefGoalStatusTypeModel> RefGoalStatusTypeList = new List<RefGoalStatusTypeModel>
        {
            new RefGoalStatusType { Id=Guid.Parse("24a4124b-3b6d-4756-9b34-7a2b3e5dce13"), Code="Completed", Description="Completed", Definition="Completed is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("cf8e4ef8-b276-47a7-b621-0780188f9377"), Code="Other", Description="Other", Definition="The status toward achievement of the annual goal or short-term objectives is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("87bf61ef-bd98-4a44-bf74-b9d8d548549c"), Code="SatisfactoryProgress", Description="Satisfactory Progress", Definition="Satisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("af76847d-9ef4-4167-bcde-eca451cc538f"), Code="UnsatisfactoryProgress", Description="Unsatisfactory Progress", Definition="Unsatisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefGoalStatusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGoalStatusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGoalStatusType { Id=Guid.Parse("24a4124b-3b6d-4756-9b34-7a2b3e5dce13"), Description="Completed", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("cf8e4ef8-b276-47a7-b621-0780188f9377"), Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("87bf61ef-bd98-4a44-bf74-b9d8d548549c"), Description="Satisfactory Progress", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("af76847d-9ef4-4167-bcde-eca451cc538f"), Description="Unsatisfactory Progress", SortOrder=Convert.ToDecimal("") },
       };
   }
}
