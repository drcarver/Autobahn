//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPreKEligibleAgesNonIDEAList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPreKEligibleAgesNonIDEA Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPreKEligibleAgesNonIDEA"> List
         /// </summary>
        public static List<RefPreKEligibleAgesNonIDEA> RefPreKEligibleAgesNonIDEAList = new List<RefPreKEligibleAgesNonIDEA> =
        {
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("998b8602-e68f-474c-8fd6-26360bc8c68f"), Code="The prekindergarten program is available to students aged 0-2.", Description="Age0-2", Definition="", SortOrder=0 },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("bdf1530b-a655-42e7-a209-03a98e52123d"), Code="The prekindergarten program is available to students aged 3.", Description="Age3", Definition="", SortOrder=0 },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("8eeca5d8-d150-4954-abf7-67fc3f6cbaca"), Code="The prekindergarten program is available to students aged 4.", Description="Age4", Definition="", SortOrder=0 },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("1166d75a-af0c-4aed-add4-07b77bb02a93"), Code="No pre-kindergarten is available or only for IDEA students.", Description="NoPreK", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPreKEligibleAgesNonIDEA Pick List
         /// </summary>
        public static List<RefPreKEligibleAgesNonIDEA> RefPreKEligibleAgesNonIDEAPickList = new List<RefPreKEligibleAgesNonIDEA> =
        {
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("998b8602-e68f-474c-8fd6-26360bc8c68f"), Code="The prekindergarten program is available to students aged 0-2.", SortOrder=0 },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("bdf1530b-a655-42e7-a209-03a98e52123d"), Code="The prekindergarten program is available to students aged 3.", SortOrder=0 },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("8eeca5d8-d150-4954-abf7-67fc3f6cbaca"), Code="The prekindergarten program is available to students aged 4.", SortOrder=0 },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("1166d75a-af0c-4aed-add4-07b77bb02a93"), Code="No pre-kindergarten is available or only for IDEA students.", SortOrder=0 },
       };
   }
}
