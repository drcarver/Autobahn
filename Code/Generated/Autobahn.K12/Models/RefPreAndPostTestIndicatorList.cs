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
        /// The complete <see cref="RefPreAndPostTestIndicator"> List
         /// </summary>
        public static List<RefPreAndPostTestIndicator> RefPreAndPostTestIndicatorList = new List<RefPreAndPostTestIndicator>
        {
            new RefPreAndPostTestIndicator { Id=Guid.Parse("996f50a1-0056-4099-a4ae-83d75867b314"), Code="PreAndPostTest", Description="The student took both a pre-test and post-test", Definition="The student took both a pre-test and post-test.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreAndPostTestIndicator { Id=Guid.Parse("0ee15365-95d8-4046-bb95-4f04f2034ce2"), Code="DidNotTakeBoth", Description="The student did not take both a pre-test and a post-test", Definition="The student did not take both a pre-test and a post-test.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefPreAndPostTestIndicator Pick List
         /// </summary>
        public static List<RefPreAndPostTestIndicator> RefPreAndPostTestIndicatorPickList = new List<RefPreAndPostTestIndicator>
        {
            new RefPreAndPostTestIndicator { Id=Guid.Parse("996f50a1-0056-4099-a4ae-83d75867b314"), Code="PreAndPostTest", Description="The student took both a pre-test and post-test", SortOrder=Convert.ToDecimal("1.00") },
            new RefPreAndPostTestIndicator { Id=Guid.Parse("0ee15365-95d8-4046-bb95-4f04f2034ce2"), Code="DidNotTakeBoth", Description="The student did not take both a pre-test and a post-test", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
