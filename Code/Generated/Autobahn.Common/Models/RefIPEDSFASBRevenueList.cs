//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBRevenueList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSFASBRevenue Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSFASBRevenueModel"> List
         /// </summary>
        public static List<RefIPEDSFASBRevenueModel> RefIPEDSFASBRevenueList = new List<RefIPEDSFASBRevenueModel>
        {
            new RefIPEDSFASBRevenue { Id=Guid.Parse("53ca6e54-fed8-4e0c-8e6d-5d01c2e221b2"), Code="Contributionsfromaffiliatedentities", Description="Contributions from affiliated entities", Definition="Used for reporting all revenues received from non-consolidated affiliated entities, such as fund raising foundations, booster clubs, other institutionally-related foundations, and similar organizations created to support the institution or organizational components of the institution.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("21cc8f36-7a4e-4f13-8874-ff0ae1e3c134"), Code="Federalappropriations", Description="Federal appropriations", Definition="Used for reporting all amounts received from the federal government through a direct appropriation of Congress, except grants and contracts. An example of a federal appropriation is a federal land-grant appropriation. Does not include Pell Grants or any ARRA revenues.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("522a43a3-fdbb-4bef-9ee8-39b9524c3305"), Code="Federalgrantscontracts", Description="Federal grants and contracts", Definition="Used for reporting all revenues from federal agencies that are for specific undertakings such as research projects, training projects, and similar activities, including contributions from federal agencies. If federal Pell and similar student aid grants are treated as agency transactions in your GPFS, they are excluded from this amount. If federal Pell and similar student aid grants are treated as student aid expenses or as allowances when awarded, they are included from this amount. Does not include any ARRA revenues.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("5bb77b85-2de3-4599-a885-fa49825e516f"), Code="Hospitalrevenuenottobereportedby", Description="Hospital revenue (not to be reported by less-than-4-year institutions)", Definition="Used for reporting the amount of revenues generated by the auxiliary enterprise operations, net of any allowances applied in the general purpose financial statements. Auxiliary enterprises are operations that exist to furnish a service to students, faculty, or staff, and that charge a fee that is directly related to the cost of the service. Examples are residence halls, food services, student health services, intercollegiate athletics, college unions, college stores, and movie theaters.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("3c64e507-a66c-437d-aecc-5447b59e7169"), Code="Independentoperationsrevenuenottobe", Description="Independent operations revenue (not to be reported by less-than-4-year institutions)", Definition="Used for reporting the revenues and gains of hospitals operated as a component of a reporting institution of higher education. If your hospital is reporting in IPEDS educational program activity that is conducted separate from an institution of higher education, they are excluded from this amount.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("8e289138-1d44-4152-ace4-3fdacb17fb8a"), Code="Investmentreturn", Description="Investment return", Definition="Used for reporting all investment income (i.e., interest, dividends, rents and royalties), gains and losses (realized and unrealized) from holding investments (regardless of the nature of the investment), student loan interest, and amounts distributed from irrevocable trusts held by others (collectively referred to as \u0022investment return\u0022). Changes in the value of interest rate swaps should be included in this amount.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("07aa873b-3f05-4ed0-adf4-0a82da70538a"), Code="Localappropriations", Description="Local appropriations", Definition="Used for reporting all amounts received from a local government (i.e., city and/or county) through a direct appropriation of its legislative body, except for local grants and contracts. An example of a local appropriation is an annual local appropriation for operating expenses of the institution.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("da3cd6e2-e1cf-472f-986c-b57619621f90"), Code="Localgrantscontracts", Description="Local grants and contracts", Definition="Used for reporting all revenues from local government agencies that are for specific undertakings such as research projects, training projects, and similar activities, including contributions from local agencies. If local grants for student aid are treated as agency transactions in your GPFS, they are excluded from this amount. If local grants for student aid are treated in your GPFS as student aid expenses or as allowances when awarded, they are included from this amount.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("2fe8012e-4cc3-4913-bfd3-2668528535b1"), Code="Netassetsreleasedfromrestriction", Description="Net assets released from restriction", Definition="Includes all other revenue not reported elsewhere.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("f7c3db21-e94d-49fc-8a7d-1d53a2e615c7"), Code="Otherrevenue", Description="Other revenue", Definition="Used for reporting all revenues associated with operations independent of the primary missions of the institution. This category generally includes only those revenues associated with major federally-funded research and development centers. Does not include the profit (or loss) from operations owned and managed as investments of the institution's endowment funds.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("1e5687ce-5e53-4b76-a8be-636a87a846a4"), Code="Privategifts", Description="Private gifts", Definition="Used for reporting revenues from private (non-governmental) entities including revenues received from gift or contribution nonexchange transactions (including contributed services) except those from affiliated entities. Includes bequests, promises to give (pledges), gifts from an affiliated organization or a component unit not blended or consolidated, and income from funds held in irrevocable trusts or distributable at the direction of the trustees of the trusts. Includes any contributed services recognized (recorded) by the institution.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("77d44e05-2199-4198-94fd-d12ce0b60902"), Code="Privategrantscontracts", Description="Private grants and contracts", Definition="Used for reporting revenues from private (non-governmental) entities that are for specific research projects, other types of programs, or for general institutional operations (if not government appropriations). Examples are research projects, training programs, and similar activities for which amounts are received or expenses are reimbursable under the terms of a grant or contract, including amounts to cover both direct and indirect expenses.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("e62edf21-7047-4e10-889a-54eb5c634772"), Code="Salesservicesofauxiliaryenterprisesnetofallowance", Description="Sales and services of auxiliary enterprises (net of allowance)", Definition="Used for reporting the amount of revenues generated by the auxiliary enterprise operations, net of any allowances applied in the general purpose financial statements. Auxiliary enterprises are operations that exist to furnish a service to students, faculty, or staff, and that charge a fee that is directly related to the cost of the service. Examples are residence halls, food services, student health services, intercollegiate athletics, college unions, college stores, and movie theaters.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("46ebf068-2412-4ef8-9078-6e90ef776403"), Code="Salesservicesofeducationalactivities", Description="Sales and services of educational activities", Definition="Used for reporting all revenues derived from the sales of goods or services that are incidental to the conduct of instruction, research or public service, and revenues of activities that exist to provide instructional and laboratory experience for students and that incidentally create goods and services that may be sold. Examples include film rentals, scientific and literary publications, testing services, university presses, dairies, and patient care clinics that are not part of a hospital.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("42bfa5bd-1694-4d3f-84eb-eb6c31c13c22"), Code="Stateappropriations", Description="State appropriations", Definition="Used for reporting all amounts received from a state government through a direct appropriation of its legislative body, except for state grants and contracts. An example of a state appropriation is an annual state appropriation for operating expenses of the institution. (FARM para. 463) Does not include any ARRA revenues.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("b0d8ae4c-f787-4818-a8ef-405b2d49b755"), Code="Stategrantscontracts", Description="State grants and contracts", Definition="Used for reporting all revenues from state government agencies that are for specific undertakings such as research projects, training projects, and similar activities, including contributions from state agencies. If state grants for student aid are treated as agency transactions in your GPFS, they are excluded from this amount. If state grants for student aid are treated in your GPFS as student aid expenses or as allowances when awarded, include the grant revenue on this line and in Part C. Does not include any ARRA revenues.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("f316030a-15ac-470e-98bb-5905193f3d65"), Code="Tuitionfeesnetofallowance", Description="Tuition and fees (net of allowance)", Definition="Used for reporting the amount of tuition and educational fees, net of any allowances applied in the GPFS. Include in this amount all fees for continuing education programs, conferences, and seminars.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIPEDSFASBRevenue Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIPEDSFASBRevenueViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIPEDSFASBRevenue { Id=Guid.Parse("53ca6e54-fed8-4e0c-8e6d-5d01c2e221b2"), Description="Contributions from affiliated entities", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("21cc8f36-7a4e-4f13-8874-ff0ae1e3c134"), Description="Federal appropriations", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("522a43a3-fdbb-4bef-9ee8-39b9524c3305"), Description="Federal grants and contracts", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("5bb77b85-2de3-4599-a885-fa49825e516f"), Description="Hospital revenue (not to be reported by less-than-4-year institutions)", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("3c64e507-a66c-437d-aecc-5447b59e7169"), Description="Independent operations revenue (not to be reported by less-than-4-year institutions)", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("8e289138-1d44-4152-ace4-3fdacb17fb8a"), Description="Investment return", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("07aa873b-3f05-4ed0-adf4-0a82da70538a"), Description="Local appropriations", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("da3cd6e2-e1cf-472f-986c-b57619621f90"), Description="Local grants and contracts", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("2fe8012e-4cc3-4913-bfd3-2668528535b1"), Description="Net assets released from restriction", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("f7c3db21-e94d-49fc-8a7d-1d53a2e615c7"), Description="Other revenue", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("1e5687ce-5e53-4b76-a8be-636a87a846a4"), Description="Private gifts", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("77d44e05-2199-4198-94fd-d12ce0b60902"), Description="Private grants and contracts", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("e62edf21-7047-4e10-889a-54eb5c634772"), Description="Sales and services of auxiliary enterprises (net of allowance)", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("46ebf068-2412-4ef8-9078-6e90ef776403"), Description="Sales and services of educational activities", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("42bfa5bd-1694-4d3f-84eb-eb6c31c13c22"), Description="State appropriations", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("b0d8ae4c-f787-4818-a8ef-405b2d49b755"), Description="State grants and contracts", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenue { Id=Guid.Parse("f316030a-15ac-470e-98bb-5905193f3d65"), Description="Tuition and fees (net of allowance)", SortOrder=Convert.ToDecimal("") },
       };
   }
}
