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
        /// The complete <see cref="RefItemResponseTheoryKappaAlgorithmModel"> List
         /// </summary>
        public static List<RefItemResponseTheoryKappaAlgorithmModel> RefItemResponseTheoryKappaAlgorithmList = new List<RefItemResponseTheoryKappaAlgorithmModel>
        {
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("ea83ddf8-9dad-4a8f-a19f-7aad3244f980"), Code="CohenUnweighted", Description="Cohen's unweighted algorithm", Definition="Cohen's unweighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("4533cb21-7d5d-4078-a118-c2a4145a9c2e"), Code="CohenWeighted", Description="Cohen's weighted algorithm", Definition="Cohen's weighted algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("a878048a-7319-4a75-a824-ba10575c59fe"), Code="FleissAlgorithm", Description="Fleiss algorithm", Definition="Fleiss algorithm is specified as the algorithm used to derive the Assessment Item Kappa Value.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefItemResponseTheoryKappaAlgorithm Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefItemResponseTheoryKappaAlgorithmViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("ea83ddf8-9dad-4a8f-a19f-7aad3244f980"), Description="Cohen's unweighted algorithm", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("4533cb21-7d5d-4078-a118-c2a4145a9c2e"), Description="Cohen's weighted algorithm", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryKappaAlgorithm { Id=Guid.Parse("a878048a-7319-4a75-a824-ba10575c59fe"), Description="Fleiss algorithm", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
