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
        public static List<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfList = new List<RefReasonDelayTransitionConf> =
        {
            new RefReasonDelayTransitionConf { Id=Guid.Parse("68f9ac84-6b19-4e55-8a97-992a8f2e4ff3"), Code="The reasons for the delay of a transition conference is attributed to the family.", Description="Family", Definition="", SortOrder=0 },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("bb22dd07-647d-44bb-9e42-5b8ecfdd1b02"), Code="The reasons for the delay of a transition conference is attributed to the program.", Description="Program", Definition="", SortOrder=0 },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("f30e0668-8a04-4c30-a57d-988d9d1c6716"), Code="The reasons for the delay of a transition conference is other, beyond the control of the program.", Description="BeyondProgramControl", Definition="", SortOrder=0 },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("87075dc1-1233-4e97-b2fe-48229a3136b1"), Code="The reasons for the delay of a transition conference is attributed to promotion or advancement.", Description="Promotion", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefReasonDelayTransitionConf Pick List
         /// </summary>
        public static List<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfPickList = new List<RefReasonDelayTransitionConf> =
        {
            new RefReasonDelayTransitionConf { Id=Guid.Parse("68f9ac84-6b19-4e55-8a97-992a8f2e4ff3"), Code="The reasons for the delay of a transition conference is attributed to the family.", SortOrder=0 },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("bb22dd07-647d-44bb-9e42-5b8ecfdd1b02"), Code="The reasons for the delay of a transition conference is attributed to the program.", SortOrder=0 },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("f30e0668-8a04-4c30-a57d-988d9d1c6716"), Code="The reasons for the delay of a transition conference is other, beyond the control of the program.", SortOrder=0 },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("87075dc1-1233-4e97-b2fe-48229a3136b1"), Code="The reasons for the delay of a transition conference is attributed to promotion or advancement.", SortOrder=0 },
       };
   }
}
