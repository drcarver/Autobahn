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
        /// The complete <see cref="RefOutcomeTimePoint"> List
         /// </summary>
        public static List<RefOutcomeTimePoint> RefOutcomeTimePointList = new List<RefOutcomeTimePoint>
        {
            new RefOutcomeTimePoint { Id=Guid.Parse("524bb678-6b8e-4c0a-a478-54a9197167eb"), Code="Baseline", Description="Baseline - at entry", Definition="Baseline - at entry is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("540f391a-2ab1-445e-b9d2-04f5cde25c56"), Code="AtExit", Description="At exit", Definition="At exit is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("4.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("3891db92-c182-4a89-92f8-4ee3fee7ae71"), Code="NA", Description="Not applicable", Definition="Not applicable is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("6.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("5ef96643-1af8-42f5-af16-5028936dbccd"), Code="Other", Description="Other", Definition="Other is the point in time for which the result is used for an outcome measure.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefOutcomeTimePoint Pick List
         /// </summary>
        public static List<RefOutcomeTimePoint> RefOutcomeTimePointPickList = new List<RefOutcomeTimePoint>
        {
            new RefOutcomeTimePoint { Id=Guid.Parse("524bb678-6b8e-4c0a-a478-54a9197167eb"), Code="Baseline", Description="Baseline - at entry", SortOrder=Convert.ToDecimal("2.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("540f391a-2ab1-445e-b9d2-04f5cde25c56"), Code="AtExit", Description="At exit", SortOrder=Convert.ToDecimal("4.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("3891db92-c182-4a89-92f8-4ee3fee7ae71"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("6.00") },
            new RefOutcomeTimePoint { Id=Guid.Parse("5ef96643-1af8-42f5-af16-5028936dbccd"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
