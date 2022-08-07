//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramDayLengthList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProgramDayLength Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramDayLengthModel"> List
         /// </summary>
        public static List<RefProgramDayLengthModel> RefProgramDayLengthList = new List<RefProgramDayLengthModel>
        {
            new RefProgramDayLength { Id=Guid.Parse("158c2d2a-91b2-4265-8a9d-81b94c83b627"), Code="FullDay", Description="Full-day", Definition="The program is provided to the students it serves as a full-day program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramDayLength { Id=Guid.Parse("d2117881-6b8d-4c1a-b36b-f84bcf671442"), Code="Part-day", Description="Part-day", Definition="The program is provided to the students it serves as a part-day program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramDayLength { Id=Guid.Parse("2df281a1-2871-4236-aff7-5f0eb6ec9fdc"), Code="NotProvided", Description="Not provided", Definition="Program is not provided.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefProgramDayLength Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProgramDayLengthViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProgramDayLength { Id=Guid.Parse("158c2d2a-91b2-4265-8a9d-81b94c83b627"), Description="Full-day", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramDayLength { Id=Guid.Parse("d2117881-6b8d-4c1a-b36b-f84bcf671442"), Description="Part-day", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramDayLength { Id=Guid.Parse("2df281a1-2871-4236-aff7-5f0eb6ec9fdc"), Description="Not provided", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
