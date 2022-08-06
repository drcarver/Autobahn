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
        public static List<RefOutcomeTimePoint> RefOutcomeTimePointList = new List<RefOutcomeTimePoint> =
        {
            new RefOutcomeTimePoint { Id=Guid.Parse("481d89ae-56de-4888-a32c-78d2b5bad795"), Code="Baseline - at entry is the point in time for which the result is used for an outcome measure.", Description="Baseline", Definition="", SortOrder=0 },
            new RefOutcomeTimePoint { Id=Guid.Parse("38d9bc9d-a907-413a-997a-338e79c91809"), Code="At exit is the point in time for which the result is used for an outcome measure.", Description="AtExit", Definition="", SortOrder=0 },
            new RefOutcomeTimePoint { Id=Guid.Parse("2da1c68e-0f09-4f97-9084-9085aebca9bb"), Code="Not applicable is the point in time for which the result is used for an outcome measure.", Description="NA", Definition="", SortOrder=0 },
            new RefOutcomeTimePoint { Id=Guid.Parse("c485090e-09cb-40ff-8ac2-9441bf5a3598"), Code="Other is the point in time for which the result is used for an outcome measure.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefOutcomeTimePoint Pick List
         /// </summary>
        public static List<RefOutcomeTimePoint> RefOutcomeTimePointPickList = new List<RefOutcomeTimePoint> =
        {
            new RefOutcomeTimePoint { Id=Guid.Parse("481d89ae-56de-4888-a32c-78d2b5bad795"), Code="Baseline - at entry is the point in time for which the result is used for an outcome measure.", SortOrder=0 },
            new RefOutcomeTimePoint { Id=Guid.Parse("38d9bc9d-a907-413a-997a-338e79c91809"), Code="At exit is the point in time for which the result is used for an outcome measure.", SortOrder=0 },
            new RefOutcomeTimePoint { Id=Guid.Parse("2da1c68e-0f09-4f97-9084-9085aebca9bb"), Code="Not applicable is the point in time for which the result is used for an outcome measure.", SortOrder=0 },
            new RefOutcomeTimePoint { Id=Guid.Parse("c485090e-09cb-40ff-8ac2-9441bf5a3598"), Code="Other is the point in time for which the result is used for an outcome measure.", SortOrder=0 },
       };
   }
}
