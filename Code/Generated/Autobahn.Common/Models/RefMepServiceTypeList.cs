//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepServiceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepServiceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepServiceType"> List
         /// </summary>
        public static List<RefMepServiceType> RefMepServiceTypeList = new List<RefMepServiceType>
        {
            new RefMepServiceType { Id=Guid.Parse("1bb43172-5e49-4a04-9758-8f49b365a41c"), Code="CounselingServices", Description="Counseling Services", Definition="Counseling Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepServiceType { Id=Guid.Parse("24988111-8216-422e-a617-a913a28c6cdf"), Code="HighSchoolAccrual", Description="High School Accrual", Definition="High School Accrual provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepServiceType { Id=Guid.Parse("e4086f08-74bf-4b5e-b35a-4dc61d29e22b"), Code="InstructionalServices", Description="Instructional Services", Definition="Instructional Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepServiceType { Id=Guid.Parse("4dae7ece-961e-4ac1-b00c-faf8e732813f"), Code="MathematicsInstruction", Description="Mathematics Instruction", Definition="Mathematics Instruction provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepServiceType { Id=Guid.Parse("9e3e08ca-d248-4040-8ca2-96a31909c75f"), Code="ReadingInstruction", Description="Reading Instruction", Definition="Reading Instruction provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepServiceType { Id=Guid.Parse("f1afe50b-954e-496c-aca9-536a424ecad1"), Code="ReferralServices", Description="Referral Services", Definition="Referral Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefMepServiceType { Id=Guid.Parse("c21f650f-85ec-4520-9bbe-979dd17d0f1a"), Code="SupportServices", Description="Support Services", Definition="Support Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefMepServiceType Pick List
         /// </summary>
        public static List<RefMepServiceType> RefMepServiceTypePickList = new List<RefMepServiceType>
        {
            new RefMepServiceType { Id=Guid.Parse("1bb43172-5e49-4a04-9758-8f49b365a41c"), Code="CounselingServices", Description="Counseling Services", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepServiceType { Id=Guid.Parse("24988111-8216-422e-a617-a913a28c6cdf"), Code="HighSchoolAccrual", Description="High School Accrual", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepServiceType { Id=Guid.Parse("e4086f08-74bf-4b5e-b35a-4dc61d29e22b"), Code="InstructionalServices", Description="Instructional Services", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepServiceType { Id=Guid.Parse("4dae7ece-961e-4ac1-b00c-faf8e732813f"), Code="MathematicsInstruction", Description="Mathematics Instruction", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepServiceType { Id=Guid.Parse("9e3e08ca-d248-4040-8ca2-96a31909c75f"), Code="ReadingInstruction", Description="Reading Instruction", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepServiceType { Id=Guid.Parse("f1afe50b-954e-496c-aca9-536a424ecad1"), Code="ReferralServices", Description="Referral Services", SortOrder=Convert.ToDecimal("6.00") },
            new RefMepServiceType { Id=Guid.Parse("c21f650f-85ec-4520-9bbe-979dd17d0f1a"), Code="SupportServices", Description="Support Services", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
