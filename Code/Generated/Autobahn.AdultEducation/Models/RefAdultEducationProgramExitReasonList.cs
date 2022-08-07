//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAdultEducationProgramExitReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAdultEducationProgramExitReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdultEducationProgramExitReasonModel"> List
         /// </summary>
        public static List<RefAdultEducationProgramExitReasonModel> RefAdultEducationProgramExitReasonList = new List<RefAdultEducationProgramExitReasonModel>
        {
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("1cc58f35-6f69-4800-87b0-48cc56823141"), Code="1003", Description="Deceased", Definition="The participant is deceased.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("2436b904-2879-4aa4-91a4-4f2dfa5bd637"), Code="1000", Description="Incarceration in a correctional institution or resident of 24-hour support facility", Definition="The participant exits the program because he or she has become incarcerated in a correctional institution or has become a resident of an institution or facility providing 24-hour support such as a hospital or treatment center during the course of receiving services as a participant.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("5f8b6fc2-6d75-4428-aa19-d90c105c68ed"), Code="1001", Description="Medical treatment", Definition="The participant exits the program because of medical treatment and that treatment is expected to last longer than 90 days and precludes entry into unsubsidized employment or continued participation in the program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("f8fa8ecb-b26e-4772-9b2a-97d0675c613b"), Code="1006", Description="Moved out of state", Definition="The participant moved out of state.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("089afa76-50a5-4330-bb06-4aa1584a4f52"), Code="1002", Description="National guard or other reserve active duty", Definition="The participant exits the program because the participant is a member of the National Guard or other reserve military unit of the armed forces and is called to active duty for at least 90 days.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("eec4cbd9-680c-48be-ad9a-75cef4af2c80"), Code="1004", Description="Permanently incapacitated", Definition="The participant is permanently incapacitated.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("3b78ced4-85d1-412f-8a72-ab8e6869c504"), Code="1010", Description="Program completion with credential or certification", Definition="The participant completed the program with one or more credentials or certifications.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("cb4d4795-3330-412e-abe9-ea84ac953fe4"), Code="1007", Description="Program completion without credential or certification", Definition="The participant completed the program without credentials or certifications.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("4571fed6-a02a-47fb-b692-fd785617cf17"), Code="1008", Description="Program discontinued", Definition="The participant exited the program because the program was discontinued.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("a3980506-d033-46f8-bc35-3e6290b85d97"), Code="1009", Description="Unknown", Definition="It is unknown why the participant exited the program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("7ff01627-bb2f-4a06-8a68-8d53b37f9ebf"), Code="1005", Description="Voluntary exit", Definition="The participant voluntarily exited the program without completing.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("dde8bed6-b583-4f78-9287-f57abe52d9e9"), Code="1999", Description="Other", Definition="The reason why the person is no longer being served in the adult education program is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefAdultEducationProgramExitReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdultEducationProgramExitReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("1cc58f35-6f69-4800-87b0-48cc56823141"), Description="Deceased", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("2436b904-2879-4aa4-91a4-4f2dfa5bd637"), Description="Incarceration in a correctional institution or resident of 24-hour support facility", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("5f8b6fc2-6d75-4428-aa19-d90c105c68ed"), Description="Medical treatment", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("f8fa8ecb-b26e-4772-9b2a-97d0675c613b"), Description="Moved out of state", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("089afa76-50a5-4330-bb06-4aa1584a4f52"), Description="National guard or other reserve active duty", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("eec4cbd9-680c-48be-ad9a-75cef4af2c80"), Description="Permanently incapacitated", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("3b78ced4-85d1-412f-8a72-ab8e6869c504"), Description="Program completion with credential or certification", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("cb4d4795-3330-412e-abe9-ea84ac953fe4"), Description="Program completion without credential or certification", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("4571fed6-a02a-47fb-b692-fd785617cf17"), Description="Program discontinued", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("a3980506-d033-46f8-bc35-3e6290b85d97"), Description="Unknown", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("7ff01627-bb2f-4a06-8a68-8d53b37f9ebf"), Description="Voluntary exit", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("dde8bed6-b583-4f78-9287-f57abe52d9e9"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
