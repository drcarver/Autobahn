//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefItemResponseTheoryKappaAlgorithmList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefItemResponseTheoryKappaAlgorithm Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefItemResponseTheoryKappaAlgorithm"> List
         /// </summary>
        public static List<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithmList = new List<RefItemResponseTheoryKappaAlgorithm> =
        {
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("cdb3cf44-a0ac-4ee6-a018-58ff39da18ff"), Code="Cohen's unweighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", Description="CohenUnweighted", Definition="", SortOrder=0 },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("7e3334a0-da23-4c43-9bfd-17626f7f7e68"), Code="Cohen's weighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", Description="CohenWeighted", Definition="", SortOrder=0 },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("1ecbca39-10ec-480c-b180-6f3fa79f3577"), Code="Fleiss algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", Description="FleissAlgorithm", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefItemResponseTheoryKappaAlgorithm Pick List
         /// </summary>
        public static List<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithmPickList = new List<RefItemResponseTheoryKappaAlgorithm> =
        {
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("cdb3cf44-a0ac-4ee6-a018-58ff39da18ff"), Code="Cohen's unweighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=0 },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("7e3334a0-da23-4c43-9bfd-17626f7f7e68"), Code="Cohen's weighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=0 },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("1ecbca39-10ec-480c-b180-6f3fa79f3577"), Code="Fleiss algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=0 },
       };
   }
}
