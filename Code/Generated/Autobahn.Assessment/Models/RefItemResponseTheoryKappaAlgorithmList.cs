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
        public static List<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithmList = new List<RefItemResponseTheoryKappaAlgorithm>
        {
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("0b718ddf-ad3d-4c1c-8a66-84a5c27f1460"), Code="CohenUnweighted", Description="Cohen's unweighted algorithm", Definition="Cohen's unweighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("e687e7f3-49a3-4dd2-83a7-6810b2f53d8b"), Code="CohenWeighted", Description="Cohen's weighted algorithm", Definition="Cohen's weighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("2151a94f-87b9-48ee-b0bf-460de9f253f9"), Code="FleissAlgorithm", Description="Fleiss algorithm", Definition="Fleiss algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefItemResponseTheoryKappaAlgorithm Pick List
         /// </summary>
        public static List<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithmPickList = new List<RefItemResponseTheoryKappaAlgorithm>
        {
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("0b718ddf-ad3d-4c1c-8a66-84a5c27f1460"), Code="CohenUnweighted", Description="Cohen's unweighted algorithm", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("e687e7f3-49a3-4dd2-83a7-6810b2f53d8b"), Code="CohenWeighted", Description="Cohen's weighted algorithm", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("2151a94f-87b9-48ee-b0bf-460de9f253f9"), Code="FleissAlgorithm", Description="Fleiss algorithm", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
