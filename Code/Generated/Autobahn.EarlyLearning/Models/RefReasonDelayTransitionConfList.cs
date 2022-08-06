//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefReasonDelayTransitionConfList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefReasonDelayTransitionConf Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefReasonDelayTransitionConf"> List
         /// </summary>
        public static List<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfList = new List<RefReasonDelayTransitionConf>
        {
            new RefReasonDelayTransitionConf { Id=Guid.Parse("2027c68f-28b3-4a1f-bb10-fd5c96adb990"), Code="Family", Description="Family", Definition="The reasons for the delay of a transition conference is attributed to the family.", SortOrder=Convert.ToDecimal("2.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("006f94e4-5e1e-41fd-a52e-9ae45a0635b0"), Code="Program", Description="Program", Definition="The reasons for the delay of a transition conference is attributed to the program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("4aafb3b3-be8a-401b-9fcb-41aec57dd5ee"), Code="BeyondProgramControl", Description="Other beyond the control of the program", Definition="The reasons for the delay of a transition conference is other, beyond the control of the program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("aa19e131-7db0-407c-a529-09cd1d9383d9"), Code="Promotion", Description="Promotion or advancement", Definition="The reasons for the delay of a transition conference is attributed to promotion or advancement.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefReasonDelayTransitionConf Pick List
         /// </summary>
        public static List<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfPickList = new List<RefReasonDelayTransitionConf>
        {
            new RefReasonDelayTransitionConf { Id=Guid.Parse("2027c68f-28b3-4a1f-bb10-fd5c96adb990"), Code="Family", Description="Family", SortOrder=Convert.ToDecimal("2.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("006f94e4-5e1e-41fd-a52e-9ae45a0635b0"), Code="Program", Description="Program", SortOrder=Convert.ToDecimal("4.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("4aafb3b3-be8a-401b-9fcb-41aec57dd5ee"), Code="BeyondProgramControl", Description="Other beyond the control of the program", SortOrder=Convert.ToDecimal("6.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("aa19e131-7db0-407c-a529-09cd1d9383d9"), Code="Promotion", Description="Promotion or advancement", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
