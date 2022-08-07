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
        /// The complete <see cref="RefPreKEligibleAgesNonIDEAModel"> List
         /// </summary>
        public static List<RefPreKEligibleAgesNonIDEAModel> RefPreKEligibleAgesNonIDEAList = new List<RefPreKEligibleAgesNonIDEAModel>
        {
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("c1241e40-e479-4557-8f4c-9ec326cd0de7"), Code="Age0-2", Description="Students aged 0-2", Definition="The prekindergarten program is available to students aged 0-2.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("a63bbc77-605e-40fc-a3a5-463c31504621"), Code="Age3", Description="Students aged 3", Definition="The prekindergarten program is available to students aged 3.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("0cc76382-cd2f-4d01-a21d-7522fb97b4fe"), Code="Age4", Description="Students aged 4", Definition="The prekindergarten program is available to students aged 4.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("86cd45ef-d59f-415b-b1ee-5abf8cc52960"), Code="NoPreK", Description="No pre-kindergarten or only for IDEA students", Definition="No pre-kindergarten is available or only for IDEA students.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefPreKEligibleAgesNonIDEA Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPreKEligibleAgesNonIDEAViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("c1241e40-e479-4557-8f4c-9ec326cd0de7"), Description="Students aged 0-2", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("a63bbc77-605e-40fc-a3a5-463c31504621"), Description="Students aged 3", SortOrder=Convert.ToDecimal("2.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("0cc76382-cd2f-4d01-a21d-7522fb97b4fe"), Description="Students aged 4", SortOrder=Convert.ToDecimal("3.00") },
            new RefPreKEligibleAgesNonIDEA { Id=Guid.Parse("86cd45ef-d59f-415b-b1ee-5abf8cc52960"), Description="No pre-kindergarten or only for IDEA students", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
