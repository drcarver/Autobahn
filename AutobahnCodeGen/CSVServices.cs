﻿// *******************************************************************************************************
//   File:      CSVServices.cs
//   CreatedAt: 07/26/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using Autobahn.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AutobahnCodeGen
{

    public class CSVServices
    {
        public List<CEDSElement> ReadCEDSElementsFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound=null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<CEDSMap>();
                        var records = csv.GetRecords<CEDSElement>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<AutobahnElement> ReadAutobahnElementsFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<CEDSMap>();
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

        public List<AutobahnTable> ReadTablesFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
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

        public List<ReferenceModel> ReadReferenceFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<ReferenceModelMap>();
                        var records = csv.GetRecords<ReferenceModel>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                return new List<ReferenceModel>();
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

        public void WriteTablesFile(string location, List<AutobahnTable> tables)
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|" };
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(tables);
                }
            }
        }

        public void WriteAutobahnElementFile(string location, List<AutobahnElement> elements)
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(elements);
            }
        }
    }
}