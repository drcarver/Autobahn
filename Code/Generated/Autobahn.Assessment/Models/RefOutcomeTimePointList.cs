//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefOutcomeTimePointList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefOutcomeTimePoint Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOutcomeTimePointModel"> List
         /// </summary>
        public static List<RefOutcomeTimePointModel> RefOutcomeTimePointList = new List<RefOutcomeTimePointModel>
        {
            new RefOutcomeTimePoint { Id=Guid.Parse("87f2d416-09b0-4697-bc89-ba4ebb40e93b"), Code="Baseline", Description="Baseline - at entry", Definition="Baseline - at entry is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("9ad54e98-f3a6-484d-8b04-6aa4b27c7846"), Code="AtExit", Description="At exit", Definition="At exit is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("4.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("6bb541aa-66fe-460e-afba-c4d1bf2438bd"), Code="NA", Description="Not applicable", Definition="Not applicable is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("6.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("54660cec-a29f-4154-ba6a-0d074a5f238d"), Code="Other", Description="Other", Definition="Other is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefOutcomeTimePoint Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefOutcomeTimePointViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefOutcomeTimePoint { Id=Guid.Parse("87f2d416-09b0-4697-bc89-ba4ebb40e93b"), Description="Baseline - at entry", SortOrder=Convert.ToDecimal("2.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("9ad54e98-f3a6-484d-8b04-6aa4b27c7846"), Description="At exit", SortOrder=Convert.ToDecimal("4.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("6bb541aa-66fe-460e-afba-c4d1bf2438bd"), Description="Not applicable", SortOrder=Convert.ToDecimal("6.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("54660cec-a29f-4154-ba6a-0d074a5f238d"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
