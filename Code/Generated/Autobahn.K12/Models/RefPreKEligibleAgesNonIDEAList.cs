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
        public static List<RefPreKEligibleAgesNonIDEA> RefPreKEligibleAgesNonIDEAList = new List<RefPreKEligibleAgesNonIDEA>
        {
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("463f51d1-eecc-4008-90cd-e0440f0048b2"), Code="Age0-2", Description="Students aged 0-2", Definition="The prekindergarten program is available to students aged 0-2.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("e5c84069-4ceb-40f3-ba09-8a19ebf2d498"), Code="Age3", Description="Students aged 3", Definition="The prekindergarten program is available to students aged 3.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("9275adb6-5111-4722-b5b8-91e901e238ab"), Code="Age4", Description="Students aged 4", Definition="The prekindergarten program is available to students aged 4.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("3783ea6f-084b-4978-bc80-fd6bb455ffbc"), Code="NoPreK", Description="No pre-kindergarten or only for IDEA students", Definition="No pre-kindergarten is available or only for IDEA students.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefPreKEligibleAgesNonIDEA Pick List
         /// </summary>
        public static List<RefPreKEligibleAgesNonIDEA> RefPreKEligibleAgesNonIDEAPickList = new List<RefPreKEligibleAgesNonIDEA>
        {
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("463f51d1-eecc-4008-90cd-e0440f0048b2"), Code="Age0-2", Description="Students aged 0-2", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("e5c84069-4ceb-40f3-ba09-8a19ebf2d498"), Code="Age3", Description="Students aged 3", SortOrder=Convert.ToDecimal("2.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("9275adb6-5111-4722-b5b8-91e901e238ab"), Code="Age4", Description="Students aged 4", SortOrder=Convert.ToDecimal("3.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("3783ea6f-084b-4978-bc80-fd6bb455ffbc"), Code="NoPreK", Description="No pre-kindergarten or only for IDEA students", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
