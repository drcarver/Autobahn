//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepServiceTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepServiceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepServiceTypeModel"> List
         /// </summary>
        public static List<RefMepServiceTypeModel> RefMepServiceTypeList = new List<RefMepServiceTypeModel>
        {
            new RefMepServiceType { Id=Guid.Parse("53ff60c0-b43a-41f7-817b-5b509646941a"), Code="CounselingServices", Description="Counseling Services", Definition="Counseling Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepServiceType { Id=Guid.Parse("146da81c-83b1-47dc-a79f-9b423abafead"), Code="HighSchoolAccrual", Description="High School Accrual", Definition="High School Accrual provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepServiceType { Id=Guid.Parse("a48a16d7-eedd-46cb-aa1b-44fc6b791b36"), Code="InstructionalServices", Description="Instructional Services", Definition="Instructional Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepServiceType { Id=Guid.Parse("81282e3e-ec0b-46f4-b91b-a3b5b7d8bee9"), Code="MathematicsInstruction", Description="Mathematics Instruction", Definition="Mathematics Instruction provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepServiceType { Id=Guid.Parse("9809ff03-c18e-498d-a719-210f3c7424eb"), Code="ReadingInstruction", Description="Reading Instruction", Definition="Reading Instruction provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepServiceType { Id=Guid.Parse("8220b605-ad1d-48c8-93b7-70f18fd185bf"), Code="ReferralServices", Description="Referral Services", Definition="Referral Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefMepServiceType { Id=Guid.Parse("057bd98c-f2b1-482b-adb3-42e924d4fb0f"), Code="SupportServices", Description="Support Services", Definition="Support Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefMepServiceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMepServiceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMepServiceType { Id=Guid.Parse("53ff60c0-b43a-41f7-817b-5b509646941a"), Description="Counseling Services", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepServiceType { Id=Guid.Parse("146da81c-83b1-47dc-a79f-9b423abafead"), Description="High School Accrual", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepServiceType { Id=Guid.Parse("a48a16d7-eedd-46cb-aa1b-44fc6b791b36"), Description="Instructional Services", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepServiceType { Id=Guid.Parse("81282e3e-ec0b-46f4-b91b-a3b5b7d8bee9"), Description="Mathematics Instruction", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepServiceType { Id=Guid.Parse("9809ff03-c18e-498d-a719-210f3c7424eb"), Description="Reading Instruction", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepServiceType { Id=Guid.Parse("8220b605-ad1d-48c8-93b7-70f18fd185bf"), Description="Referral Services", SortOrder=Convert.ToDecimal("6.00") },
            new RefMepServiceType { Id=Guid.Parse("057bd98c-f2b1-482b-adb3-42e924d4fb0f"), Description="Support Services", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
