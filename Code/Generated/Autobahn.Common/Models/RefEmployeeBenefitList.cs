//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployeeBenefitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployeeBenefit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployeeBenefit"> List
         /// </summary>
        public static List<RefEmployeeBenefit> RefEmployeeBenefitList = new List<RefEmployeeBenefit>
        {
            new RefEmployeeBenefit { Id=Guid.Parse("4fbeff03-420e-4b9a-9c7e-784a0e58bb6a"), Code="01", Description="Health insurance", Definition="Health insurance is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("3f8586f0-5131-494e-8a96-052e3681d984"), Code="02", Description="Dental insurance", Definition="Dental insurance is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("cb6afe65-1d2f-4f10-937c-0aea898b7868"), Code="03", Description="Vision", Definition="Vision benefits are offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("80f872d3-3405-4790-8398-fdba4fef2467"), Code="04", Description="Disability insurance", Definition="Disability insurance is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("cd5ad47c-8764-42cd-bb33-edec3f90ff64"), Code="05", Description="Retirement", Definition="Retirement benefits are offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("f436a1a2-310a-4652-b201-4d5103fc46bf"), Code="06", Description="Professional membership fees paid", Definition="Professional membership fee payment is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("12315931-308f-4db5-962f-e07a99e59412"), Code="07", Description="Sick leave", Definition="Sick leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("7.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("df46d562-1bac-49a6-a393-194d3cbe2ee6"), Code="08", Description="Leave", Definition="Leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("8.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("a4d0afbe-1a7e-4a25-8885-d007f963866d"), Code="09", Description="Vacation", Definition="Vacation is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("9.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("bcd18566-868a-4b85-8e2b-74adf117b652"), Code="10", Description="Holiday", Definition="Holiday is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("10.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("252db255-7979-44e9-bb41-334e9f809e31"), Code="11", Description="Personal leave", Definition="Personal leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("11.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("b46e17d1-51b9-4bdf-a62d-059bb400fdb8"), Code="12", Description="Family leave", Definition="Family leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("12.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("4387e1d7-49d3-4faa-ad06-ee4c07c67d85"), Code="13", Description="Bereavement leave", Definition="Bereavement leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("13.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("d1382fb3-cb4c-4dc2-9b4b-0a782372478c"), Code="14", Description="Jury duty leave", Definition="Jury duty leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("14.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("d41b3d25-afa0-40df-88f3-7521e30f445f"), Code="15", Description="Life insurance", Definition="Life insurance is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("15.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("c1c3bce8-4a20-4810-8d24-02e32bb07db5"), Code="16", Description="Maternity leave", Definition="Maternity leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("16.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("bb9cdce3-7274-4747-9a6b-89e227da7abd"), Code="17", Description="Paternity leave", Definition="Paternity leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("17.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("82718bf4-82c3-40b7-9c75-d1f2990c509b"), Code="18", Description="Family medical leave", Definition="Family medical leave is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("18.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("0f90ba70-d9f2-4370-b76d-60ee28b66bb6"), Code="19", Description="Flex plan-dependent care", Definition="Flex plan-dependent care is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("19.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("ee117884-0c5f-4974-96eb-e459e73d055f"), Code="20", Description="Flex plan-medical (MSA/HSA)", Definition="Flex plan-medical (MSA/HSA) is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("20.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("78ae87d4-1422-4386-8b28-a10e8c2b115b"), Code="21", Description="Transportation", Definition="Transportation is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("21.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("5954ca35-a0f1-4a86-b560-95d9f81ac890"), Code="22", Description="Parking", Definition="Parking is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("22.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("26f02199-cf81-4363-9090-c74df02ce539"), Code="23", Description="Flex schedule/time", Definition="Flex schedule/time is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("23.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("a7fa45fe-dc0f-4c8a-ae4c-9113372f2232"), Code="24", Description="Employee Assistance Program (EAP)", Definition="Employee Assistance Program (EAP) is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("24.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("87ef4a37-60fd-4d49-b650-8fb4c5d334d3"), Code="25", Description="Paid training", Definition="Paid training is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("25.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("9d06a656-37db-4d97-aefb-f4f56bc8c4d2"), Code="26", Description="Tuition reimbursement", Definition="Tuition reimbursement is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("26.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("c26e148e-be83-40dc-b04b-e5acfd08bcf7"), Code="27", Description="Child care fee assistance", Definition="Child care fee assistance is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("27.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("54bd144a-5faa-4c62-b610-1550d37b28ac"), Code="28", Description="Bonus", Definition="Bonus is offered by a program/facility/employer.", SortOrder=Convert.ToDecimal("28.00") },
        };

        /// <summary>
        /// The RefEmployeeBenefit Pick List
         /// </summary>
        public static List<RefEmployeeBenefit> RefEmployeeBenefitPickList = new List<RefEmployeeBenefit>
        {
            new RefEmployeeBenefit { Id=Guid.Parse("4fbeff03-420e-4b9a-9c7e-784a0e58bb6a"), Code="01", Description="Health insurance", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("3f8586f0-5131-494e-8a96-052e3681d984"), Code="02", Description="Dental insurance", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("cb6afe65-1d2f-4f10-937c-0aea898b7868"), Code="03", Description="Vision", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("80f872d3-3405-4790-8398-fdba4fef2467"), Code="04", Description="Disability insurance", SortOrder=Convert.ToDecimal("4.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("cd5ad47c-8764-42cd-bb33-edec3f90ff64"), Code="05", Description="Retirement", SortOrder=Convert.ToDecimal("5.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("f436a1a2-310a-4652-b201-4d5103fc46bf"), Code="06", Description="Professional membership fees paid", SortOrder=Convert.ToDecimal("6.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("12315931-308f-4db5-962f-e07a99e59412"), Code="07", Description="Sick leave", SortOrder=Convert.ToDecimal("7.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("df46d562-1bac-49a6-a393-194d3cbe2ee6"), Code="08", Description="Leave", SortOrder=Convert.ToDecimal("8.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("a4d0afbe-1a7e-4a25-8885-d007f963866d"), Code="09", Description="Vacation", SortOrder=Convert.ToDecimal("9.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("bcd18566-868a-4b85-8e2b-74adf117b652"), Code="10", Description="Holiday", SortOrder=Convert.ToDecimal("10.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("252db255-7979-44e9-bb41-334e9f809e31"), Code="11", Description="Personal leave", SortOrder=Convert.ToDecimal("11.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("b46e17d1-51b9-4bdf-a62d-059bb400fdb8"), Code="12", Description="Family leave", SortOrder=Convert.ToDecimal("12.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("4387e1d7-49d3-4faa-ad06-ee4c07c67d85"), Code="13", Description="Bereavement leave", SortOrder=Convert.ToDecimal("13.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("d1382fb3-cb4c-4dc2-9b4b-0a782372478c"), Code="14", Description="Jury duty leave", SortOrder=Convert.ToDecimal("14.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("d41b3d25-afa0-40df-88f3-7521e30f445f"), Code="15", Description="Life insurance", SortOrder=Convert.ToDecimal("15.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("c1c3bce8-4a20-4810-8d24-02e32bb07db5"), Code="16", Description="Maternity leave", SortOrder=Convert.ToDecimal("16.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("bb9cdce3-7274-4747-9a6b-89e227da7abd"), Code="17", Description="Paternity leave", SortOrder=Convert.ToDecimal("17.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("82718bf4-82c3-40b7-9c75-d1f2990c509b"), Code="18", Description="Family medical leave", SortOrder=Convert.ToDecimal("18.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("0f90ba70-d9f2-4370-b76d-60ee28b66bb6"), Code="19", Description="Flex plan-dependent care", SortOrder=Convert.ToDecimal("19.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("ee117884-0c5f-4974-96eb-e459e73d055f"), Code="20", Description="Flex plan-medical (MSA/HSA)", SortOrder=Convert.ToDecimal("20.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("78ae87d4-1422-4386-8b28-a10e8c2b115b"), Code="21", Description="Transportation", SortOrder=Convert.ToDecimal("21.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("5954ca35-a0f1-4a86-b560-95d9f81ac890"), Code="22", Description="Parking", SortOrder=Convert.ToDecimal("22.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("26f02199-cf81-4363-9090-c74df02ce539"), Code="23", Description="Flex schedule/time", SortOrder=Convert.ToDecimal("23.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("a7fa45fe-dc0f-4c8a-ae4c-9113372f2232"), Code="24", Description="Employee Assistance Program (EAP)", SortOrder=Convert.ToDecimal("24.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("87ef4a37-60fd-4d49-b650-8fb4c5d334d3"), Code="25", Description="Paid training", SortOrder=Convert.ToDecimal("25.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("9d06a656-37db-4d97-aefb-f4f56bc8c4d2"), Code="26", Description="Tuition reimbursement", SortOrder=Convert.ToDecimal("26.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("c26e148e-be83-40dc-b04b-e5acfd08bcf7"), Code="27", Description="Child care fee assistance", SortOrder=Convert.ToDecimal("27.00") },
            new RefEmployeeBenefit { Id=Guid.Parse("54bd144a-5faa-4c62-b610-1550d37b28ac"), Code="28", Description="Bonus", SortOrder=Convert.ToDecimal("28.00") },
       };
   }
}
