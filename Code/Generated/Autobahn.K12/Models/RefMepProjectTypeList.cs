//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepProjectTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepProjectType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepProjectTypeModel"> List
         /// </summary>
        public static List<RefMepProjectTypeModel> RefMepProjectTypeList = new List<RefMepProjectTypeModel>
        {
            new RefMepProjectType { Id=Guid.Parse("d3b2fe77-19e9-4025-a872-76be7aff3760"), Code="SchoolDay", Description="Regular school year - school day only", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day only.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectType { Id=Guid.Parse("72b89db7-19cc-4aa5-bdee-cb3f6176a671"), Code="ExtendedDay", Description="Regular school year - school day/extended day", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day/extended day.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepProjectType { Id=Guid.Parse("2dc0cdc3-5418-482a-bd88-6346180dabc9"), Code="SummerIntersession", Description="Summer/intersession only", Definition="The project funded in whole or in part by Migrant Education Program funds is available during summer/intersession only.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepProjectType { Id=Guid.Parse("05f0bcff-8484-42bd-8fd2-9bf3700fe0f4"), Code="YearRound", Description="Year round", Definition="The project funded in whole or in part by Migrant Education Program funds is available year round.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefMepProjectType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMepProjectTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMepProjectType { Id=Guid.Parse("d3b2fe77-19e9-4025-a872-76be7aff3760"), Description="Regular school year - school day only", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectType { Id=Guid.Parse("72b89db7-19cc-4aa5-bdee-cb3f6176a671"), Description="Regular school year - school day/extended day", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepProjectType { Id=Guid.Parse("2dc0cdc3-5418-482a-bd88-6346180dabc9"), Description="Summer/intersession only", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepProjectType { Id=Guid.Parse("05f0bcff-8484-42bd-8fd2-9bf3700fe0f4"), Description="Year round", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
