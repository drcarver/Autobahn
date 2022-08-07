//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCreditHoursAppliedOtherProgramList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCreditHoursAppliedOtherProgram Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCreditHoursAppliedOtherProgramModel"> List
         /// </summary>
        public static List<RefCreditHoursAppliedOtherProgramModel> RefCreditHoursAppliedOtherProgramList = new List<RefCreditHoursAppliedOtherProgramModel>
        {
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("9840a215-bd54-44a2-bbc5-9db0e5407279"), Code="00", Description="None", Definition="None is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("80ee3c02-22a6-48ce-ba51-93a4bf91f61b"), Code="01", Description="Undergraduate hours applied towards graduate degree", Definition="Undergraduate hours applied towards graduate degree is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("35aeee9e-f89d-4c45-aff8-0c80d2005385"), Code="02", Description="Credit hours taken at the postbaccalaureate level", Definition="Credit hours taken at the postbaccalaureate level is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("87d5746b-529c-4346-98eb-63d4f2bb9f20"), Code="03", Description="Credit hours taken as unclassified student", Definition="Credit hours taken as unclassified student is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("9f4d3ce5-e244-4b3a-b838-d68e85a91004"), Code="04", Description="Credit hours taken as an independent student", Definition="Credit hours taken as an independent student is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("3103e4c1-9905-430e-b4a8-e7f500d2a2fb"), Code="05", Description="Credit hours taken as traveling scholar at another university", Definition="Credit hours taken as traveling scholar at another university is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("50ed6cc1-961e-4337-9f35-c0e5f23b6cf4"), Code="06", Description="Credit hours taken at master's level", Definition="Credit hours taken at master's level is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("d69839f8-8359-4c8e-b56d-c9941102e2d0"), Code="07", Description="Credit hours taken as a master's student in one program, applied towards another master's program", Definition="Credit hours taken as a master's student in one program, applied towards another master's program is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("e72dfc0b-07ac-40df-8abb-6ffd0a446b1b"), Code="98", Description="Unknown", Definition="Unknown is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("ef5d6b92-6466-4206-a140-64f35adea302"), Code="99", Description="Other", Definition="Other is specified as the set of credit hours taken in other programs or degrees that were applied to the individual's degree.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The Reference RefCreditHoursAppliedOtherProgram Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCreditHoursAppliedOtherProgramViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("9840a215-bd54-44a2-bbc5-9db0e5407279"), Description="None", SortOrder=Convert.ToDecimal("2.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("80ee3c02-22a6-48ce-ba51-93a4bf91f61b"), Description="Undergraduate hours applied towards graduate degree", SortOrder=Convert.ToDecimal("4.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("35aeee9e-f89d-4c45-aff8-0c80d2005385"), Description="Credit hours taken at the postbaccalaureate level", SortOrder=Convert.ToDecimal("6.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("87d5746b-529c-4346-98eb-63d4f2bb9f20"), Description="Credit hours taken as unclassified student", SortOrder=Convert.ToDecimal("8.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("9f4d3ce5-e244-4b3a-b838-d68e85a91004"), Description="Credit hours taken as an independent student", SortOrder=Convert.ToDecimal("10.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("3103e4c1-9905-430e-b4a8-e7f500d2a2fb"), Description="Credit hours taken as traveling scholar at another university", SortOrder=Convert.ToDecimal("12.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("50ed6cc1-961e-4337-9f35-c0e5f23b6cf4"), Description="Credit hours taken at master's level", SortOrder=Convert.ToDecimal("14.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("d69839f8-8359-4c8e-b56d-c9941102e2d0"), Description="Credit hours taken as a master's student in one program, applied towards another master's program", SortOrder=Convert.ToDecimal("16.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("e72dfc0b-07ac-40df-8abb-6ffd0a446b1b"), Description="Unknown", SortOrder=Convert.ToDecimal("18.00") },
            new RefCreditHoursAppliedOtherProgram { Id=Guid.Parse("ef5d6b92-6466-4206-a140-64f35adea302"), Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
