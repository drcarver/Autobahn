//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentSessionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentSessionTypeModel"> List
         /// </summary>
        public static List<RefAssessmentSessionTypeModel> RefAssessmentSessionTypeList = new List<RefAssessmentSessionTypeModel>
        {
            new RefAssessmentSessionType { Id=Guid.Parse("79170a55-712d-4135-8abc-e968b4b2d039"), Code="Standard", Description="Standard", Definition="Standard is specified as the type of assessment session that is scheduled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentSessionType { Id=Guid.Parse("664504e7-9c35-43e4-bf18-691f0d136c1a"), Code="Accommodation", Description="Accommodation", Definition="Accommodation is specified as the type of assessment session that is scheduled.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentSessionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentSessionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentSessionType { Id=Guid.Parse("79170a55-712d-4135-8abc-e968b4b2d039"), Description="Standard", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentSessionType { Id=Guid.Parse("664504e7-9c35-43e4-bf18-691f0d136c1a"), Description="Accommodation", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
