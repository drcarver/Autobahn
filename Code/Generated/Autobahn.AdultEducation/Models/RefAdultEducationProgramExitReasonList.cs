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
        /// The complete <see cref="RefAdultEducationProgramExitReason"> List
         /// </summary>
        public static List<RefAdultEducationProgramExitReason> RefAdultEducationProgramExitReasonList = new List<RefAdultEducationProgramExitReason>
        {
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("bdef40d6-ae61-4db5-aebc-647c94a4e4c8"), Code="1003", Description="Deceased", Definition="The participant is deceased.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("32fdb147-3ae2-4905-b942-30a5ed4f2a6b"), Code="1000", Description="Incarceration in a correctional institution or resident of 24-hour support facility", Definition="The participant exits the program because he or she has become incarcerated in a correctional institution or has become a resident of an institution or facility providing 24-hour support such as a hospital or treatment center during the course of receiving services as a participant.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("abcdf639-758b-4138-b168-68f275b5fb23"), Code="1001", Description="Medical treatment", Definition="The participant exits the program because of medical treatment and that treatment is expected to last longer than 90 days and precludes entry into unsubsidized employment or continued participation in the program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("6c7b9d6b-c17a-40e4-aa90-aec1c8f7f752"), Code="1006", Description="Moved out of state", Definition="The participant moved out of state.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("e7f7c5d5-e83b-4336-960a-c8a86f4cce81"), Code="1002", Description="National guard or other reserve active duty", Definition="The participant exits the program because the participant is a member of the National Guard or other reserve military unit of the armed forces and is called to active duty for at least 90 days.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("e1620bb2-4a40-40e3-96bb-e369aa12b8fd"), Code="1004", Description="Permanently incapacitated", Definition="The participant is permanently incapacitated.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("a5fe944c-3979-4cca-804d-55da92c78aeb"), Code="1010", Description="Program completion with credential or certification", Definition="The participant completed the program with one or more credentials or certifications.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("2be53749-1526-4c26-9905-89616bce3e75"), Code="1007", Description="Program completion without credential or certification", Definition="The participant completed the program without credentials or certifications.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("0a170b6a-4675-4bf6-bbfd-33b8d4177f0b"), Code="1008", Description="Program discontinued", Definition="The participant exited the program because the program was discontinued.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("5c27779a-a70c-40d8-b94e-38821b56b69b"), Code="1009", Description="Unknown", Definition="It is unknown why the participant exited the program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("dfa6a5c4-8071-44fa-87bc-abeb5d086f4e"), Code="1005", Description="Voluntary exit", Definition="The participant voluntarily exited the program without completing.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("787814c6-6f09-4bce-ac9e-de775de18eae"), Code="1999", Description="Other", Definition="The reason why the person is no longer being served in the adult education program is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefAdultEducationProgramExitReason Pick List
         /// </summary>
        public static List<RefAdultEducationProgramExitReason> RefAdultEducationProgramExitReasonPickList = new List<RefAdultEducationProgramExitReason>
        {
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("bdef40d6-ae61-4db5-aebc-647c94a4e4c8"), Code="1003", Description="Deceased", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("32fdb147-3ae2-4905-b942-30a5ed4f2a6b"), Code="1000", Description="Incarceration in a correctional institution or resident of 24-hour support facility", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("abcdf639-758b-4138-b168-68f275b5fb23"), Code="1001", Description="Medical treatment", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("6c7b9d6b-c17a-40e4-aa90-aec1c8f7f752"), Code="1006", Description="Moved out of state", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("e7f7c5d5-e83b-4336-960a-c8a86f4cce81"), Code="1002", Description="National guard or other reserve active duty", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("e1620bb2-4a40-40e3-96bb-e369aa12b8fd"), Code="1004", Description="Permanently incapacitated", SortOrder=Convert.ToDecimal("6.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("a5fe944c-3979-4cca-804d-55da92c78aeb"), Code="1010", Description="Program completion with credential or certification", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("2be53749-1526-4c26-9905-89616bce3e75"), Code="1007", Description="Program completion without credential or certification", SortOrder=Convert.ToDecimal("8.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("0a170b6a-4675-4bf6-bbfd-33b8d4177f0b"), Code="1008", Description="Program discontinued", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("5c27779a-a70c-40d8-b94e-38821b56b69b"), Code="1009", Description="Unknown", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("dfa6a5c4-8071-44fa-87bc-abeb5d086f4e"), Code="1005", Description="Voluntary exit", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdultEducationProgramExitReason { Id=Guid.Parse("787814c6-6f09-4bce-ac9e-de775de18eae"), Code="1999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
