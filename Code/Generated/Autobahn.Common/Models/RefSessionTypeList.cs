//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSessionTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSessionTypeModel"> List
         /// </summary>
        public static List<RefSessionTypeModel> RefSessionTypeList = new List<RefSessionTypeModel>
        {
            new RefSessionType { Id=Guid.Parse("03aea209-7772-4dc5-8b89-045f01c6d031"), Code="FullSchoolYear", Description="Full School Year", Definition="A regular school term consisting of no major subdivision of time segments. It usually begins in the late summer or early fall and ends in late spring or early summer (e.g., elementary school).", SortOrder=Convert.ToDecimal("1.00") },
            new RefSessionType { Id=Guid.Parse("1a0d78a4-dd04-4059-bda2-3226613e9bbc"), Code="Intersession", Description="Intersession", Definition="A short session which occurs between longer sessions.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSessionType { Id=Guid.Parse("af5639eb-7f9c-4004-afcd-31692f8f4b5e"), Code="LongSession", Description="Long Session", Definition="A session that is longer than a semester but shorter than a full year.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSessionType { Id=Guid.Parse("dccf90f5-35cb-40c4-a4f5-642c23c5004f"), Code="MiniTerm", Description="Mini Term", Definition="A school term which is shorter than a regular session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSessionType { Id=Guid.Parse("1f5dda53-364b-4c27-82dc-81c131069fa1"), Code="Quarter", Description="Quarter", Definition="One of four equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSessionType { Id=Guid.Parse("38101907-9ba9-4c0d-a1c0-df07bb903e3f"), Code="Quinmester", Description="Quinmester", Definition="One of five equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSessionType { Id=Guid.Parse("17c99b92-8b3a-418f-b263-7cbd25d951ba"), Code="Semester", Description="Semester", Definition="One of two equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSessionType { Id=Guid.Parse("1b358679-e689-4852-a0ac-8cf8a460dfb9"), Code="SummerTerm", Description="Summer Term", Definition="A school term which takes place in the summer between two regular school terms.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSessionType { Id=Guid.Parse("7a445f6c-ef93-47ec-94ff-6d39bec1c3a5"), Code="Trimester", Description="Trimester", Definition="One of three equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSessionType { Id=Guid.Parse("fc606333-732b-4ea1-b6ec-9b61debe1a24"), Code="TwelveMonth", Description="Twelve Month", Definition="An educational program that operates on a full twelve month cycle.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSessionType { Id=Guid.Parse("9c8b5077-9949-456d-8b10-c6f0ad5e9aea"), Code="Other", Description="Other", Definition="The session type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefSessionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSessionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSessionType { Id=Guid.Parse("03aea209-7772-4dc5-8b89-045f01c6d031"), Description="Full School Year", SortOrder=Convert.ToDecimal("1.00") },
            new RefSessionType { Id=Guid.Parse("1a0d78a4-dd04-4059-bda2-3226613e9bbc"), Description="Intersession", SortOrder=Convert.ToDecimal("2.00") },
            new RefSessionType { Id=Guid.Parse("af5639eb-7f9c-4004-afcd-31692f8f4b5e"), Description="Long Session", SortOrder=Convert.ToDecimal("3.00") },
            new RefSessionType { Id=Guid.Parse("dccf90f5-35cb-40c4-a4f5-642c23c5004f"), Description="Mini Term", SortOrder=Convert.ToDecimal("4.00") },
            new RefSessionType { Id=Guid.Parse("1f5dda53-364b-4c27-82dc-81c131069fa1"), Description="Quarter", SortOrder=Convert.ToDecimal("5.00") },
            new RefSessionType { Id=Guid.Parse("38101907-9ba9-4c0d-a1c0-df07bb903e3f"), Description="Quinmester", SortOrder=Convert.ToDecimal("6.00") },
            new RefSessionType { Id=Guid.Parse("17c99b92-8b3a-418f-b263-7cbd25d951ba"), Description="Semester", SortOrder=Convert.ToDecimal("7.00") },
            new RefSessionType { Id=Guid.Parse("1b358679-e689-4852-a0ac-8cf8a460dfb9"), Description="Summer Term", SortOrder=Convert.ToDecimal("8.00") },
            new RefSessionType { Id=Guid.Parse("7a445f6c-ef93-47ec-94ff-6d39bec1c3a5"), Description="Trimester", SortOrder=Convert.ToDecimal("9.00") },
            new RefSessionType { Id=Guid.Parse("fc606333-732b-4ea1-b6ec-9b61debe1a24"), Description="Twelve Month", SortOrder=Convert.ToDecimal("10.00") },
            new RefSessionType { Id=Guid.Parse("9c8b5077-9949-456d-8b10-c6f0ad5e9aea"), Description="Other", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
