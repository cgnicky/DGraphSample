// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DGraphSample.Csv.Aotp.Mapper;
using DGraphSample.Csv.Aotp.Model;
using TinyCsvParser;

namespace DGraphSample.Csv.Aotp.Parser
{
    public static class Parsers
    {
        public static CsvParser<Flight> FlightStatisticsParser
        {
            get
            {
                CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');

                return new CsvParser<Flight>(csvParserOptions, new FlightMapper());
            }
        }

        public static CsvParser<Airport> AirportParser
        {
            get
            {
                CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');

                return new CsvParser<Airport>(csvParserOptions, new AirportMapper());
            }
        }

        public static CsvParser<Carrier> CarrierParser
        {
            get
            {
                CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');

                return new CsvParser<Carrier>(csvParserOptions, new CarrierMapper());
            }
        }
    }
}