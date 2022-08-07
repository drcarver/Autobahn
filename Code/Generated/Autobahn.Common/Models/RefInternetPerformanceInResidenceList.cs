//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetPerformanceInResidenceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInternetPerformanceInResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInternetPerformanceInResidenceModel"> List
         /// </summary>
        public static List<RefInternetPerformanceInResidenceModel> RefInternetPerformanceInResidenceList = new List<RefInternetPerformanceInResidenceModel>
        {
            new RefInternetPerformanceInResidence { Id=Guid.Parse("a1a5e251-4df4-40fe-8121-415698a15239"), Code="No", Description="No", Definition="The student is unable to complete learning activities due to poor internet performance in their primary place of residence.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("fdb0b60c-5c23-47c9-90c2-53e241b89951"), Code="Sometimes", Description="Sometimes", Definition="The student regularly experiences interruptions in learning activities caused by poor internet performance in their primary place of residence.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("4c54d96b-87fc-42ec-9b1f-122219e20bb9"), Code="Yes", Description="Yes", Definition="The student experiences very few or no interruptions in learning activities caused by poor internet performance in their primary place of residence.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefInternetPerformanceInResidence Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInternetPerformanceInResidenceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInternetPerformanceInResidence { Id=Guid.Parse("a1a5e251-4df4-40fe-8121-415698a15239"), Description="No", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("fdb0b60c-5c23-47c9-90c2-53e241b89951"), Description="Sometimes", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("4c54d96b-87fc-42ec-9b1f-122219e20bb9"), Description="Yes", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
