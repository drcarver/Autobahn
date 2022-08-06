// *******************************************************************************************************
//   File:      CEDSService.cs
//   CreatedAt: 07/26/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using AutobahnCodeGen.AutobahnCodeGen;
using CsvHelper;
using CsvHelper.Configuration;

namespace AutobahnCodeGen
{

    //using (TextWriter writer = new StreamWriter(@"C:\test.csv", false, System.Text.Encoding.UTF8))
    //{
    //    var csv = new CsvWriter(writer);
    //    csv.WriteRecords(values); // where values implements IEnumerable
    //}
    public class CEDSService
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

        public List<CEDSTable> ReadTablesFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<CEDSTableMap>();
                        var records = csv.GetRecords<CEDSTable>().ToList();
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

        public void WriteTablesFile(string location, List<CEDSTable> tables)
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(tables); // where values implements IEnumerable
            }
        }

        public void WriteNDSElementFile(string location, List<NDSElement> elements)
        {
            using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
            {
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(elements); // where values implements IEnumerable
            }
        }
    }
}