﻿// *******************************************************************************************************
//   File:      CSVServices.cs
//   CreatedAt: 07/26/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using Autobahn.Codegen.Maps;
using Autobahn.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace AutobahnCodeGen
{

    public class CSVServices
    {
        public List<_CEDSElement> ReadCEDSElementsFile(string location, string delimiter = "|")
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = delimiter, BadDataFound = null, MissingFieldFound=null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<_CEDSElementMap>();
                        var records = csv.GetRecords<_CEDSElement>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<AutobahnElement> ReadAutobahnElementsFile(string location, string delimiter = "|")
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = delimiter, BadDataFound = null, MissingFieldFound = null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<AutobahnElementMap>();
                        var records = csv.GetRecords<AutobahnElement>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<AutobahnTable> ReadTablesFile(string location, bool hasHeaderRecord, string delimiter = ",")
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = hasHeaderRecord, Delimiter = delimiter };//, BadDataFound = null, MissingFieldFound = null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<AutobahnTableMap>();
                        var records = csv.GetRecords<AutobahnTable>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<AutobahnDomain> ReadDomainsFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<AutobahnDomainMap>();
                        var records = csv.GetRecords<AutobahnDomain>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void WriteAutobahnDomainsFile(string location, List<AutobahnDomain> domains)
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|" };
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(domains);
                } 
            }
        }

        public void WriteTablesFile(string location, List<AutobahnTable> tables, bool hasHeaderRecord, string delimeter = "|")
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = hasHeaderRecord, Delimiter = delimeter };
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(tables);
                }
            }
        }

        public void WriteCEDSlementFile(string location, List<_CEDSElement> elements, string delimeter = "|")
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true, Delimiter = delimeter };
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(elements);
                }
            }
        }
    }
}