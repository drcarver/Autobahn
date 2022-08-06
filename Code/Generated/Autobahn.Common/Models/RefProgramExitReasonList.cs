//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramExitReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProgramExitReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramExitReason"> List
         /// </summary>
        public static List<RefProgramExitReason> RefProgramExitReasonList = new List<RefProgramExitReason>
        {
            new RefProgramExitReason { Id=Guid.Parse("0f18d21e-393d-4e8f-b85f-7a99e25ebb6b"), Code="06262", Description="Attempts to contact the parent and/or child were unsuccessful", Definition="Attempts to contact the parent and/or child were unsuccessful.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramExitReason { Id=Guid.Parse("439131a0-5024-4600-b3d6-bd7b3b841c8a"), Code="02226", Description="Completion of IFSP prior to reaching maximum age for Part C", Definition="Completion of IFSP prior to reaching maximum age for Part C", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramExitReason { Id=Guid.Parse("4e8c9e95-31ab-4574-a821-3c6cac893fb6"), Code="01923", Description="Died or is permanently incapacitated", Definition="Died or is permanently incapacitated", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramExitReason { Id=Guid.Parse("ccd0e10a-710b-4ccf-9907-1a6fcb682d20"), Code="01927", Description="Discontinued schooling", Definition="Discontinued schooling", SortOrder=Convert.ToDecimal("6.00") },
            new RefProgramExitReason { Id=Guid.Parse("fa6eb87b-1ded-4e9d-92cb-263b59235589"), Code="02222", Description="Discontinued schooling, not special education", Definition="Discontinued schooling, not special education", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramExitReason { Id=Guid.Parse("1551140a-4ee3-4aa1-ba24-e98e4d4d2b9f"), Code="02221", Description="Discontinued schooling, special education only", Definition="Discontinued schooling, special education only", SortOrder=Convert.ToDecimal("8.00") },
            new RefProgramExitReason { Id=Guid.Parse("9086c369-faa1-4635-aad4-c696e01f1973"), Code="02227", Description="Eligible for IDEA, Part B", Definition="Eligible for IDEA, Part B", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramExitReason { Id=Guid.Parse("b2ebe647-2aaf-4a8f-8420-626878479c6c"), Code="02224", Description="Expulsion", Definition="Expulsion", SortOrder=Convert.ToDecimal("10.00") },
            new RefProgramExitReason { Id=Guid.Parse("0922a36e-f6c4-4d7e-abca-6956251ea9a4"), Code="02212", Description="Graduated with a high school diploma", Definition="Graduated with a high school diploma", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramExitReason { Id=Guid.Parse("9a4b130c-22aa-4644-95cf-87f6a1a6ce46"), Code="02231", Description="Moved out of state", Definition="Moved out of state", SortOrder=Convert.ToDecimal("12.00") },
            new RefProgramExitReason { Id=Guid.Parse("6310a3da-dc7b-4e26-89f3-62407714175b"), Code="02216", Description="No longer receiving special education", Definition="No longer receiving special education", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramExitReason { Id=Guid.Parse("52eaa37a-4324-44c4-9255-361c01708254"), Code="06261", Description="Not eligible for Part B, exit with no referrals", Definition="Not eligible for Part B, exit with no referrals", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("0cbb32be-0d22-49ba-8dd9-80924e08f3f2"), Code="73075", Description="Moved within the US, not known to be continuing", Definition="Moved within the US, not known to be continuing", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("2ba10f76-fe8a-496d-bc87-2bc83ceffa53"), Code="02228", Description="Not eligible for Part B, exit with referrals to other programs", Definition="Not eligible for Part B, exit with referrals to other programs", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramExitReason { Id=Guid.Parse("b0436cc4-e1ff-4974-a14d-ef84066d5ca9"), Code="02230", Description="Part B eligibility not determined", Definition="Part B eligibility not determined", SortOrder=Convert.ToDecimal("16.00") },
            new RefProgramExitReason { Id=Guid.Parse("9c068af8-8495-43a1-b5b5-e76c6316a71a"), Code="02214", Description="Program completion", Definition="Program completion", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramExitReason { Id=Guid.Parse("b873109d-5a49-47b6-80b3-85bd95d8be2a"), Code="02225", Description="Program discontinued", Definition="Program discontinued", SortOrder=Convert.ToDecimal("18.00") },
            new RefProgramExitReason { Id=Guid.Parse("ff426e3f-5ab3-4cb0-88ad-5f2ced527d65"), Code="02215", Description="Reached maximum age", Definition="Reached maximum age", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramExitReason { Id=Guid.Parse("7a1ee118-8188-4cb4-93d0-27a793a77031"), Code="02213", Description="Received certificate of completion, modified diploma, or finished IEP requirements", Definition="Received certificate of completion, modified diploma, or finished IEP requirements", SortOrder=Convert.ToDecimal("20.00") },
            new RefProgramExitReason { Id=Guid.Parse("48c7d130-a86e-45b2-b944-0c60994d941f"), Code="02217", Description="Refused services", Definition="Refused services", SortOrder=Convert.ToDecimal("21.00") },
            new RefProgramExitReason { Id=Guid.Parse("babe9c92-87a1-43c7-8ea6-0191c26547de"), Code="73076", Description="Student data claimed in error/never attended", Definition="Student data claimed in error/never attended", SortOrder=Convert.ToDecimal("24.00") },
            new RefProgramExitReason { Id=Guid.Parse("5615dbea-146d-4393-927d-12e97cc6e8dc"), Code="73078", Description="Student moved to another country, may or may not be continuing", Definition="Student moved to another country, may or may not be continuing", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("e51bc868-ae5d-40ba-88f3-884e43df0e0b"), Code="73079", Description="Student with disabilities remaining in school to receive transitional services", Definition="Student with disabilities who met the district graduation requirements for a regular diploma, but is remaining in school to receive transitional services deemed necessary by the IEP team.", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("b6683e12-5eac-40b8-858a-6a8edf76faea"), Code="02220", Description="Suspended from school", Definition="Suspended from school", SortOrder=Convert.ToDecimal("26.00") },
            new RefProgramExitReason { Id=Guid.Parse("22143d3c-694e-414b-aa7d-fb9662c956d4"), Code="02406", Description="Transferred to another district or school, known not to be continuing in program/service", Definition="Transferred to another district or school, known not to be continuing in program/service", SortOrder=Convert.ToDecimal("30.00") },
            new RefProgramExitReason { Id=Guid.Parse("9a2fe70c-6e1f-48fd-933c-234997d3308f"), Code="02218", Description="Transferred to another district or school, known to be continuing in program/service", Definition="Transferred to another district or school, known to be continuing in program/service", SortOrder=Convert.ToDecimal("31.00") },
            new RefProgramExitReason { Id=Guid.Parse("2ba9f996-a5d0-433d-a7b0-4e50fa88cbf4"), Code="02219", Description="Transferred to another district or school, not known to be continuing in program/service", Definition="Transferred to another district or school, not known to be continuing in program/service", SortOrder=Convert.ToDecimal("32.00") },
            new RefProgramExitReason { Id=Guid.Parse("e653c7f6-e7e2-4b88-b599-c652a7591a32"), Code="73077", Description="Transferred to a juvenile or adult correctional facility where educational services are not provided", Definition="Transferred to a juvenile or adult correctional facility where educational services are not provided", SortOrder=Convert.ToDecimal("36.00") },
            new RefProgramExitReason { Id=Guid.Parse("14dfb03e-c86d-4071-8d0c-cfc705998ff8"), Code="02233", Description="Unknown reason", Definition="Unknown reason", SortOrder=Convert.ToDecimal("37.00") },
            new RefProgramExitReason { Id=Guid.Parse("1f3849df-3d4b-4404-b858-afc5ddde58cf"), Code="02232", Description="Withdrawal by a parent (or guardian)", Definition="Withdrawal by a parent (or guardian)", SortOrder=Convert.ToDecimal("38.00") },
            new RefProgramExitReason { Id=Guid.Parse("ef150d70-62eb-4bd3-a30e-d0418861eac5"), Code="09999", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("40.00") },
        };

        /// <summary>
        /// The RefProgramExitReason Pick List
         /// </summary>
        public static List<RefProgramExitReason> RefProgramExitReasonPickList = new List<RefProgramExitReason>
        {
            new RefProgramExitReason { Id=Guid.Parse("0f18d21e-393d-4e8f-b85f-7a99e25ebb6b"), Code="06262", Description="Attempts to contact the parent and/or child were unsuccessful", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramExitReason { Id=Guid.Parse("439131a0-5024-4600-b3d6-bd7b3b841c8a"), Code="02226", Description="Completion of IFSP prior to reaching maximum age for Part C", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramExitReason { Id=Guid.Parse("4e8c9e95-31ab-4574-a821-3c6cac893fb6"), Code="01923", Description="Died or is permanently incapacitated", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramExitReason { Id=Guid.Parse("ccd0e10a-710b-4ccf-9907-1a6fcb682d20"), Code="01927", Description="Discontinued schooling", SortOrder=Convert.ToDecimal("6.00") },
            new RefProgramExitReason { Id=Guid.Parse("fa6eb87b-1ded-4e9d-92cb-263b59235589"), Code="02222", Description="Discontinued schooling, not special education", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramExitReason { Id=Guid.Parse("1551140a-4ee3-4aa1-ba24-e98e4d4d2b9f"), Code="02221", Description="Discontinued schooling, special education only", SortOrder=Convert.ToDecimal("8.00") },
            new RefProgramExitReason { Id=Guid.Parse("9086c369-faa1-4635-aad4-c696e01f1973"), Code="02227", Description="Eligible for IDEA, Part B", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramExitReason { Id=Guid.Parse("b2ebe647-2aaf-4a8f-8420-626878479c6c"), Code="02224", Description="Expulsion", SortOrder=Convert.ToDecimal("10.00") },
            new RefProgramExitReason { Id=Guid.Parse("0922a36e-f6c4-4d7e-abca-6956251ea9a4"), Code="02212", Description="Graduated with a high school diploma", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramExitReason { Id=Guid.Parse("9a4b130c-22aa-4644-95cf-87f6a1a6ce46"), Code="02231", Description="Moved out of state", SortOrder=Convert.ToDecimal("12.00") },
            new RefProgramExitReason { Id=Guid.Parse("6310a3da-dc7b-4e26-89f3-62407714175b"), Code="02216", Description="No longer receiving special education", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramExitReason { Id=Guid.Parse("52eaa37a-4324-44c4-9255-361c01708254"), Code="06261", Description="Not eligible for Part B, exit with no referrals", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("0cbb32be-0d22-49ba-8dd9-80924e08f3f2"), Code="73075", Description="Moved within the US, not known to be continuing", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramExitReason { Id=Guid.Parse("2ba10f76-fe8a-496d-bc87-2bc83ceffa53"), Code="02228", Description="Not eligible for Part B, exit with referrals to other programs", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramExitReason { Id=Guid.Parse("b0436cc4-e1ff-4974-a14d-ef84066d5ca9"), Code="02230", Description="Part B eligibility not determined", SortOrder=Convert.ToDecimal("16.00") },
            new RefProgramExitReason { Id=Guid.Parse("9c068af8-8495-43a1-b5b5-e76c6316a71a"), Code="02214", Description="Program completion", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramExitReason { Id=Guid.Parse("b873109d-5a49-47b6-80b3-85bd95d8be2a"), Code="02225", Description="Program discontinued", SortOrder=Convert.ToDecimal("18.00") },
            new RefProgramExitReason { Id=Guid.Parse("ff426e3f-5ab3-4cb0-88ad-5f2ced527d65"), Code="02215", Description="Reached maximum age", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramExitReason { Id=Guid.Parse("7a1ee118-8188-4cb4-93d0-27a793a77031"), Code="02213", Description="Received certificate of completion, modified diploma, or finished IEP requirements", SortOrder=Convert.ToDecimal("20.00") },
            new RefProgramExitReason { Id=Guid.Parse("48c7d130-a86e-45b2-b944-0c60994d941f"), Code="02217", Description="Refused services", SortOrder=Convert.ToDecimal("21.00") },
            new RefProgramExitReason { Id=Guid.Parse("babe9c92-87a1-43c7-8ea6-0191c26547de"), Code="73076", Description="Student data claimed in error/never attended", SortOrder=Convert.ToDecimal("24.00") },
            new RefProgramExitReason { Id=Guid.Parse("5615dbea-146d-4393-927d-12e97cc6e8dc"), Code="73078", Description="Student moved to another country, may or may not be continuing", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("e51bc868-ae5d-40ba-88f3-884e43df0e0b"), Code="73079", Description="Student with disabilities remaining in school to receive transitional services", SortOrder=Convert.ToDecimal("25.00") },
            new RefProgramExitReason { Id=Guid.Parse("b6683e12-5eac-40b8-858a-6a8edf76faea"), Code="02220", Description="Suspended from school", SortOrder=Convert.ToDecimal("26.00") },
            new RefProgramExitReason { Id=Guid.Parse("22143d3c-694e-414b-aa7d-fb9662c956d4"), Code="02406", Description="Transferred to another district or school, known not to be continuing in program/service", SortOrder=Convert.ToDecimal("30.00") },
            new RefProgramExitReason { Id=Guid.Parse("9a2fe70c-6e1f-48fd-933c-234997d3308f"), Code="02218", Description="Transferred to another district or school, known to be continuing in program/service", SortOrder=Convert.ToDecimal("31.00") },
            new RefProgramExitReason { Id=Guid.Parse("2ba9f996-a5d0-433d-a7b0-4e50fa88cbf4"), Code="02219", Description="Transferred to another district or school, not known to be continuing in program/service", SortOrder=Convert.ToDecimal("32.00") },
            new RefProgramExitReason { Id=Guid.Parse("e653c7f6-e7e2-4b88-b599-c652a7591a32"), Code="73077", Description="Transferred to a juvenile or adult correctional facility where educational services are not provided", SortOrder=Convert.ToDecimal("36.00") },
            new RefProgramExitReason { Id=Guid.Parse("14dfb03e-c86d-4071-8d0c-cfc705998ff8"), Code="02233", Description="Unknown reason", SortOrder=Convert.ToDecimal("37.00") },
            new RefProgramExitReason { Id=Guid.Parse("1f3849df-3d4b-4404-b858-afc5ddde58cf"), Code="02232", Description="Withdrawal by a parent (or guardian)", SortOrder=Convert.ToDecimal("38.00") },
            new RefProgramExitReason { Id=Guid.Parse("ef150d70-62eb-4bd3-a30e-d0418861eac5"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("40.00") },
       };
   }
}
