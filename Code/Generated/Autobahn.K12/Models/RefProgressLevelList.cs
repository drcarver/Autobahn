//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefProgressLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefProgressLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgressLevelModel"> List
         /// </summary>
        public static List<RefProgressLevelModel> RefProgressLevelList = new List<RefProgressLevelModel>
        {
            new RefProgressLevel { Id=Guid.Parse("3c3dd4ed-2f8a-4026-a590-d2627e51ec67"), Code="NEGGRADE", Description="Negative grade level change", Definition="The students showed a negative grade level change from the pre- to post- test", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgressLevel { Id=Guid.Parse("077e029d-c454-443e-847c-c256b19fec87"), Code="NOCHANGE", Description="No change", Definition="The students showed no change from the pre- to post- test", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgressLevel { Id=Guid.Parse("a5a9eff6-6af8-4b2e-b352-f1e1cc6af940"), Code="UPHALFGRADE", Description="Improvement of up to one half grade level", Definition="The students showed improvement of up to one half grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgressLevel { Id=Guid.Parse("985a5208-d07f-4006-818f-c8c653770b00"), Code="UPONEGRADE", Description="Improvement from one half grade level up to one full grade level", Definition="The students showed improvement from one half grade level up to one full grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgressLevel { Id=Guid.Parse("d3bdc569-64d7-473e-b42a-c6501115c629"), Code="UPGTONE", Description="Improvement of more than one full grade level", Definition="The students showed improvement of more than one full grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefProgressLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProgressLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProgressLevel { Id=Guid.Parse("3c3dd4ed-2f8a-4026-a590-d2627e51ec67"), Description="Negative grade level change", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgressLevel { Id=Guid.Parse("077e029d-c454-443e-847c-c256b19fec87"), Description="No change", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgressLevel { Id=Guid.Parse("a5a9eff6-6af8-4b2e-b352-f1e1cc6af940"), Description="Improvement of up to one half grade level", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgressLevel { Id=Guid.Parse("985a5208-d07f-4006-818f-c8c653770b00"), Description="Improvement from one half grade level up to one full grade level", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgressLevel { Id=Guid.Parse("d3bdc569-64d7-473e-b42a-c6501115c629"), Description="Improvement of more than one full grade level", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
