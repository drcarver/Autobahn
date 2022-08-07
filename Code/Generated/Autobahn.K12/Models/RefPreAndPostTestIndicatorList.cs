//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPreAndPostTestIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPreAndPostTestIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPreAndPostTestIndicatorModel"> List
         /// </summary>
        public static List<RefPreAndPostTestIndicatorModel> RefPreAndPostTestIndicatorList = new List<RefPreAndPostTestIndicatorModel>
        {
            new RefPreAndPostTestIndicator { Id=Guid.Parse("f93c59ad-c5e9-4d2f-abf6-1fb9fd432ba3"), Code="PreAndPostTest", Description="The student took both a pre-test and post-test", Definition="The student took both a pre-test and post-test.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreAndPostTestIndicator { Id=Guid.Parse("f93c68af-3cc5-4ea5-9e65-7bdb1e85d0e8"), Code="DidNotTakeBoth", Description="The student did not take both a pre-test and a post-test", Definition="The student did not take both a pre-test and a post-test.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefPreAndPostTestIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPreAndPostTestIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPreAndPostTestIndicator { Id=Guid.Parse("f93c59ad-c5e9-4d2f-abf6-1fb9fd432ba3"), Description="The student took both a pre-test and post-test", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreAndPostTestIndicator { Id=Guid.Parse("f93c68af-3cc5-4ea5-9e65-7bdb1e85d0e8"), Description="The student did not take both a pre-test and a post-test", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
