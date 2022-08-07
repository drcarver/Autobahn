//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramExitReasonList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProgramExitReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramExitReasonModel"> List
         /// </summary>
        public static List<RefProgramExitReasonModel> RefProgramExitReasonList = new List<RefProgramExitReasonModel>
        {
            new RefProgramExitReason { Id=Guid.Parse("e45a13a1-7ca2-44b7-9fe5-f1dfad0fc0af"), Code="06262", Description="Attempts to contact the parent and/or child were unsuccessful", Definition="Attempts to contact the parent and/or child were unsuccessful.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramExitReason { Id=Guid.Parse("159f959c-90fc-4668-bdbd-bd648247f190"), Code="02226", Description="Completion of IFSP prior to reaching maximum age for Part C", Definition="Completion of IFSP prior to reaching maximum age for Part C", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramExitReason { Id=Guid.Parse("2ae7a672-7d36-4cff-be39-8bde37db4e1d"), Code="01923", Description="Died or is permanently incapacitated", Definition="Died or is permanently incapacitated", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramExitReason { Id=Guid.Parse("e10b267c-3f13-41c3-b32b-faebf590ef85"), Code="01927", Description="Discontinued schooling", Definition="Discontinued schooling", SortOrder=Convert.ToDecimal("6.00") },
            new RefProgramExitReason { Id=Guid.Parse("55e54721-c2ef-4d9a-be2a-0a472c1556c9"), Code="02222", Description="Discontinued schooling, not special education", Definition="Discontinued schooling, not special education", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramExitReason { Id=Guid.Parse("e4ed544f-452c-4b7c-ade1-5818a267f9af"), Code="02221", Description="Discontinued schooling, special education only", Definition="Discontinued schooling, special education only", SortOrder=Convert.ToDecimal("8.00") },
            new RefProgramExitReason { Id=Guid.Parse("78847c0b-029e-4d65-a960-806b61621249"), Code="02227", Description="Eligible for IDEA, Part B", Definition="Eligible for IDEA, Part B", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramExitReason { Id=Guid.Parse("b0463be8-0b7f-4026-9d27-12bcdbcaf35f"), Code="02224", Description="Expulsion", Definition="Expulsion", SortOrder=Convert.ToDecimal("10.00") },
            new RefProgramExitReason { Id=Guid.Parse("1d7d3df2-46cf-4cff-a4fa-970cb906e9e9"), Code="02212", Description="Graduated with a high school diploma", Definition="Graduated with a high school diploma", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramExitReason { Id=Guid.Parse("370e32b8-9330-4619-89ce-0642fc652d09"), Code="02231", Description="Moved out of state", Definition="Moved out of state", SortOrder=Convert.ToDecimal("12.00") },
            new RefProgramExitReason { Id=Guid.Parse("e2204bc5-f37d-48fd-aeb5-1941fca750eb"), Code="02216", Description="No longer receiving special education", Definition="No longer receiving special education", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramExitReason { Id=Guid.Parse("d04dbbae-5cdf-48c5-927c-b53cf88bf13d"), Code="06261", Description="Not eligible for Part B, exit with no referrals", Definition="Not eligible for Part B, exit with no referrals", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("1c4c968b-f1c6-441b-9ca7-ef129363beef"), Code="73075", Description="Moved within the US, not known to be continuing", Definition="Moved within the US, not known to be continuing", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("2744ad2a-4d28-4df0-a260-207092cf2bb7"), Code="02228", Description="Not eligible for Part B, exit with referrals to other programs", Definition="Not eligible for Part B, exit with referrals to other programs", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramExitReason { Id=Guid.Parse("3928af4d-3f86-452c-8c73-3acd791917e3"), Code="02230", Description="Part B eligibility not determined", Definition="Part B eligibility not determined", SortOrder=Convert.ToDecimal("16.00") },
            new RefProgramExitReason { Id=Guid.Parse("8417ad93-8546-4566-b631-23a3be4996b1"), Code="02214", Description="Program completion", Definition="Program completion", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramExitReason { Id=Guid.Parse("8faca834-d90f-4573-850d-b571da712687"), Code="02225", Description="Program discontinued", Definition="Program discontinued", SortOrder=Convert.ToDecimal("18.00") },
            new RefProgramExitReason { Id=Guid.Parse("e19f4a59-7bdf-43d3-9a98-f4eb91b6e3a8"), Code="02215", Description="Reached maximum age", Definition="Reached maximum age", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramExitReason { Id=Guid.Parse("674a4fc2-7591-42fe-9ffe-87759d3651a6"), Code="02213", Description="Received certificate of completion, modified diploma, or finished IEP requirements", Definition="Received certificate of completion, modified diploma, or finished IEP requirements", SortOrder=Convert.ToDecimal("20.00") },
            new RefProgramExitReason { Id=Guid.Parse("3ff146e4-24f3-47b0-931d-486e06461917"), Code="02217", Description="Refused services", Definition="Refused services", SortOrder=Convert.ToDecimal("21.00") },
            new RefProgramExitReason { Id=Guid.Parse("ec8511f1-e3ce-4a16-83d6-f246a17f7fd0"), Code="73076", Description="Student data claimed in error/never attended", Definition="Student data claimed in error/never attended", SortOrder=Convert.ToDecimal("24.00") },
            new RefProgramExitReason { Id=Guid.Parse("5867b813-d592-4f7f-9eb1-357579a44974"), Code="73078", Description="Student moved to another country, may or may not be continuing", Definition="Student moved to another country, may or may not be continuing", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("51303144-4ee6-4dab-a6cd-03309529fee5"), Code="73079", Description="Student with disabilities remaining in school to receive transitional services", Definition="Student with disabilities who met the district graduation requirements for a regular diploma, but is remaining in school to receive transitional services deemed necessary by the IEP team.", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("a8df0fee-b099-47bf-807d-08f1d1da05de"), Code="02220", Description="Suspended from school", Definition="Suspended from school", SortOrder=Convert.ToDecimal("26.00") },
            new RefProgramExitReason { Id=Guid.Parse("809943a3-d99a-4cd9-9fb9-521074c4e42a"), Code="02406", Description="Transferred to another district or school, known not to be continuing in program/service", Definition="Transferred to another district or school, known not to be continuing in program/service", SortOrder=Convert.ToDecimal("30.00") },
            new RefProgramExitReason { Id=Guid.Parse("d8e3a57c-7aae-4b3c-9f6d-a3bc94fb6e28"), Code="02218", Description="Transferred to another district or school, known to be continuing in program/service", Definition="Transferred to another district or school, known to be continuing in program/service", SortOrder=Convert.ToDecimal("31.00") },
            new RefProgramExitReason { Id=Guid.Parse("c857c53a-a3b2-4b43-bf0c-56a1b8ee340a"), Code="02219", Description="Transferred to another district or school, not known to be continuing in program/service", Definition="Transferred to another district or school, not known to be continuing in program/service", SortOrder=Convert.ToDecimal("32.00") },
            new RefProgramExitReason { Id=Guid.Parse("c87c7b68-658d-48dc-a44d-d0bc9df02a25"), Code="73077", Description="Transferred to a juvenile or adult correctional facility where educational services are not provided", Definition="Transferred to a juvenile or adult correctional facility where educational services are not provided", SortOrder=Convert.ToDecimal("36.00") },
            new RefProgramExitReason { Id=Guid.Parse("b38f0f10-51b6-4240-96ad-d4bfdd7777d8"), Code="02233", Description="Unknown reason", Definition="Unknown reason", SortOrder=Convert.ToDecimal("37.00") },
            new RefProgramExitReason { Id=Guid.Parse("24f26cf3-8e47-41b6-975d-bb80e6d390da"), Code="02232", Description="Withdrawal by a parent (or guardian)", Definition="Withdrawal by a parent (or guardian)", SortOrder=Convert.ToDecimal("38.00") },
            new RefProgramExitReason { Id=Guid.Parse("eb4e98c5-10d5-4bf3-9e61-a8c68a7a25d9"), Code="09999", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("40.00") },
        };

        /// <summary>
        /// The Reference RefProgramExitReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProgramExitReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProgramExitReason { Id=Guid.Parse("e45a13a1-7ca2-44b7-9fe5-f1dfad0fc0af"), Description="Attempts to contact the parent and/or child were unsuccessful", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramExitReason { Id=Guid.Parse("159f959c-90fc-4668-bdbd-bd648247f190"), Description="Completion of IFSP prior to reaching maximum age for Part C", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramExitReason { Id=Guid.Parse("2ae7a672-7d36-4cff-be39-8bde37db4e1d"), Description="Died or is permanently incapacitated", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramExitReason { Id=Guid.Parse("e10b267c-3f13-41c3-b32b-faebf590ef85"), Description="Discontinued schooling", SortOrder=Convert.ToDecimal("6.00") },
            new RefProgramExitReason { Id=Guid.Parse("55e54721-c2ef-4d9a-be2a-0a472c1556c9"), Description="Discontinued schooling, not special education", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramExitReason { Id=Guid.Parse("e4ed544f-452c-4b7c-ade1-5818a267f9af"), Description="Discontinued schooling, special education only", SortOrder=Convert.ToDecimal("8.00") },
            new RefProgramExitReason { Id=Guid.Parse("78847c0b-029e-4d65-a960-806b61621249"), Description="Eligible for IDEA, Part B", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramExitReason { Id=Guid.Parse("b0463be8-0b7f-4026-9d27-12bcdbcaf35f"), Description="Expulsion", SortOrder=Convert.ToDecimal("10.00") },
            new RefProgramExitReason { Id=Guid.Parse("1d7d3df2-46cf-4cff-a4fa-970cb906e9e9"), Description="Graduated with a high school diploma", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramExitReason { Id=Guid.Parse("370e32b8-9330-4619-89ce-0642fc652d09"), Description="Moved out of state", SortOrder=Convert.ToDecimal("12.00") },
            new RefProgramExitReason { Id=Guid.Parse("e2204bc5-f37d-48fd-aeb5-1941fca750eb"), Description="No longer receiving special education", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramExitReason { Id=Guid.Parse("d04dbbae-5cdf-48c5-927c-b53cf88bf13d"), Description="Not eligible for Part B, exit with no referrals", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("1c4c968b-f1c6-441b-9ca7-ef129363beef"), Description="Moved within the US, not known to be continuing", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("2744ad2a-4d28-4df0-a260-207092cf2bb7"), Description="Not eligible for Part B, exit with referrals to other programs", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramExitReason { Id=Guid.Parse("3928af4d-3f86-452c-8c73-3acd791917e3"), Description="Part B eligibility not determined", SortOrder=Convert.ToDecimal("16.00") },
            new RefProgramExitReason { Id=Guid.Parse("8417ad93-8546-4566-b631-23a3be4996b1"), Description="Program completion", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramExitReason { Id=Guid.Parse("8faca834-d90f-4573-850d-b571da712687"), Description="Program discontinued", SortOrder=Convert.ToDecimal("18.00") },
            new RefProgramExitReason { Id=Guid.Parse("e19f4a59-7bdf-43d3-9a98-f4eb91b6e3a8"), Description="Reached maximum age", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramExitReason { Id=Guid.Parse("674a4fc2-7591-42fe-9ffe-87759d3651a6"), Description="Received certificate of completion, modified diploma, or finished IEP requirements", SortOrder=Convert.ToDecimal("20.00") },
            new RefProgramExitReason { Id=Guid.Parse("3ff146e4-24f3-47b0-931d-486e06461917"), Description="Refused services", SortOrder=Convert.ToDecimal("21.00") },
            new RefProgramExitReason { Id=Guid.Parse("ec8511f1-e3ce-4a16-83d6-f246a17f7fd0"), Description="Student data claimed in error/never attended", SortOrder=Convert.ToDecimal("24.00") },
            new RefProgramExitReason { Id=Guid.Parse("5867b813-d592-4f7f-9eb1-357579a44974"), Description="Student moved to another country, may or may not be continuing", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("51303144-4ee6-4dab-a6cd-03309529fee5"), Description="Student with disabilities remaining in school to receive transitional services", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("a8df0fee-b099-47bf-807d-08f1d1da05de"), Description="Suspended from school", SortOrder=Convert.ToDecimal("26.00") },
            new RefProgramExitReason { Id=Guid.Parse("809943a3-d99a-4cd9-9fb9-521074c4e42a"), Description="Transferred to another district or school, known not to be continuing in program/service", SortOrder=Convert.ToDecimal("30.00") },
            new RefProgramExitReason { Id=Guid.Parse("d8e3a57c-7aae-4b3c-9f6d-a3bc94fb6e28"), Description="Transferred to another district or school, known to be continuing in program/service", SortOrder=Convert.ToDecimal("31.00") },
            new RefProgramExitReason { Id=Guid.Parse("c857c53a-a3b2-4b43-bf0c-56a1b8ee340a"), Description="Transferred to another district or school, not known to be continuing in program/service", SortOrder=Convert.ToDecimal("32.00") },
            new RefProgramExitReason { Id=Guid.Parse("c87c7b68-658d-48dc-a44d-d0bc9df02a25"), Description="Transferred to a juvenile or adult correctional facility where educational services are not provided", SortOrder=Convert.ToDecimal("36.00") },
            new RefProgramExitReason { Id=Guid.Parse("b38f0f10-51b6-4240-96ad-d4bfdd7777d8"), Description="Unknown reason", SortOrder=Convert.ToDecimal("37.00") },
            new RefProgramExitReason { Id=Guid.Parse("24f26cf3-8e47-41b6-975d-bb80e6d390da"), Description="Withdrawal by a parent (or guardian)", SortOrder=Convert.ToDecimal("38.00") },
            new RefProgramExitReason { Id=Guid.Parse("eb4e98c5-10d5-4bf3-9e61-a8c68a7a25d9"), Description="Other", SortOrder=Convert.ToDecimal("40.00") },
       };
   }
}
