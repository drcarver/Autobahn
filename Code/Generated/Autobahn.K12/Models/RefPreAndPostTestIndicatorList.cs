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
        public static List<RefPreAndPostTestIndicator> RefPreAndPostTestIndicatorList = new List<RefPreAndPostTestIndicator> =
        {
            new RefPreAndPostTestIndicator { Id=Guid.Parse("58a2221e-bace-48b2-b5b4-6e81acd74143"), Code="The student took both a pre-test and post-test.", Description="PreAndPostTest", Definition="", SortOrder=0 },
            new RefPreAndPostTestIndicator { Id=Guid.Parse("5b197809-201d-4244-86eb-42c585b92e0b"), Code="The student did not take both a pre-test and a post-test.", Description="DidNotTakeBoth", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPreAndPostTestIndicator Pick List
         /// </summary>
        public static List<RefPreAndPostTestIndicator> RefPreAndPostTestIndicatorPickList = new List<RefPreAndPostTestIndicator> =
        {
            new RefPreAndPostTestIndicator { Id=Guid.Parse("58a2221e-bace-48b2-b5b4-6e81acd74143"), Code="The student took both a pre-test and post-test.", SortOrder=0 },
            new RefPreAndPostTestIndicator { Id=Guid.Parse("5b197809-201d-4244-86eb-42c585b92e0b"), Code="The student did not take both a pre-test and a post-test.", SortOrder=0 },
       };
   }
}
