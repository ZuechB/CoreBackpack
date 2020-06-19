
using System.Collections.Generic;

namespace CoreBackpack.Geo.US
{
    public class ConvertUSState
    {
        public static List<USState> Search(string text)
        {
            var states = new List<USState>();

            text = text.ToUpper();
            if (text.Contains("ALABAMA") || text.Contains("AL"))
            {
                states.Add(new USState()
                {
                    Name = "ALABAMA",
                    Abbreviation = "AL"
                });
            }

            if (text.Contains("ALASKA") || text.Contains("AK"))
            {
                states.Add(new USState()
                {
                    Name = "ALASKA",
                    Abbreviation = "AK"
                });
            }

            if (text.Contains("AMERICAN SAMOA") || text.Contains("AS"))
            {
                states.Add(new USState()
                {
                    Name = "AMERICAN SAMOA",
                    Abbreviation = "AS"
                });
            }

            if (text.Contains("ARIZONA") || text.Contains("AZ"))
            {
                states.Add(new USState()
                {
                    Name = "ARIZONA",
                    Abbreviation = "AZ"
                });
            }

            if (text.Contains("ARKANSAS") || text.Contains("AR"))
            {
                states.Add(new USState()
                {
                    Name = "ARKANSAS",
                    Abbreviation = "AR"
                });
            }

            if (text.Contains("CALIFORNIA") || text.Contains("CA"))
            {
                states.Add(new USState()
                {
                    Name = "CALIFORNIA",
                    Abbreviation = "CA"
                });
            }

            if (text.Contains("COLORADO") || text.Contains("CO"))
            {
                states.Add(new USState()
                {
                    Name = "COLORADO",
                    Abbreviation = "CO"
                });
            }

            if (text.Contains("CONNECTICUT") || text.Contains("CT"))
            {
                states.Add(new USState()
                {
                    Name = "CONNECTICUT",
                    Abbreviation = "CT"
                });
            }

            if (text.Contains("DELAWARE") || text.Contains("DE"))
            {
                states.Add(new USState()
                {
                    Name = "DELAWARE",
                    Abbreviation = "DE"
                });
            }

            if (text.Contains("DISTRICT OF COLUMBIA") || text.Contains("DC"))
            {
                states.Add(new USState()
                {
                    Name = "DISTRICT OF COLUMBIA",
                    Abbreviation = "DC"
                });
            }

            if (text.Contains("FEDERATED STATES OF MICRONESIA") || text.Contains("FM"))
            {
                states.Add(new USState()
                {
                    Name = "FEDERATED STATES OF MICRONESIA",
                    Abbreviation = "FM"
                });
            }

            if (text.Contains("FLORIDA") || text.Contains("FL"))
            {
                states.Add(new USState()
                {
                    Name = "FLORIDA",
                    Abbreviation = "FL"
                });
            }

            if (text.Contains("GEORGIA") || text.Contains("GA"))
            {
                states.Add(new USState()
                {
                    Name = "GEORGIA",
                    Abbreviation = "GA"
                });
            }

            if (text.Contains("GUAM") || text.Contains("GU"))
            {
                states.Add(new USState()
                {
                    Name = "GUAM",
                    Abbreviation = "GU"
                });
            }

            if (text.Contains("HAWAII") || text.Contains("HI"))
            {
                states.Add(new USState()
                {
                    Name = "HAWAII",
                    Abbreviation = "HI"
                });
            }

            if (text.Contains("IDAHO") || text.Contains("ID"))
            {
                states.Add(new USState()
                {
                    Name = "IDAHO",
                    Abbreviation = "ID"
                });
            }

            if (text.Contains("ILLINOIS") || text.Contains("IL"))
            {
                states.Add(new USState()
                {
                    Name = "ILLINOIS",
                    Abbreviation = "IL"
                });
            }

            if (text.Contains("INDIANA") || text.Contains("IN"))
            {
                states.Add(new USState()
                {
                    Name = "INDIANA",
                    Abbreviation = "IN"
                });
            }

            if (text.Contains("IOWA") || text.Contains("IA"))
            {
                states.Add(new USState()
                {
                    Name = "IOWA",
                    Abbreviation = "IA"
                });
            }

            if (text.Contains("KANSAS") || text.Contains("KS"))
            {
                states.Add(new USState()
                {
                    Name = "KANSAS",
                    Abbreviation = "KS"
                });
            }

            if (text.Contains("KENTUCKY") || text.Contains("KY"))
            {
                states.Add(new USState()
                {
                    Name = "KENTUCKY",
                    Abbreviation = "KY"
                });
            }

            if (text.Contains("LOUISIANA") || text.Contains("LA"))
            {
                states.Add(new USState()
                {
                    Name = "LOUISIANA",
                    Abbreviation = "LA"
                });
            }

            if (text.Contains("MAINE") || text.Contains("ME"))
            {
                states.Add(new USState()
                {
                    Name = "MAINE",
                    Abbreviation = "ME"
                });
            }

            if (text.Contains("MARSHALL ISLANDS") || text.Contains("MH"))
            {
                states.Add(new USState()
                {
                    Name = "MARSHALL ISLANDS",
                    Abbreviation = "MH"
                });
            }

            if (text.Contains("MARYLAND") || text.Contains("MD"))
            {
                states.Add(new USState()
                {
                    Name = "MARYLAND",
                    Abbreviation = "MD"
                });
            }

            if (text.Contains("MASSACHUSETTS") || text.Contains("MA"))
            {
                states.Add(new USState()
                {
                    Name = "MASSACHUSETTS",
                    Abbreviation = "MA"
                });
            }

            if (text.Contains("MICHIGAN") || text.Contains("MI"))
            {
                states.Add(new USState()
                {
                    Name = "MICHIGAN",
                    Abbreviation = "MI"
                });
            }

            if (text.Contains("MINNESOTA") || text.Contains("MN"))
            {
                states.Add(new USState()
                {
                    Name = "MINNESOTA",
                    Abbreviation = "MN"
                });
            }

            if (text.Contains("MISSISSIPPI") || text.Contains("MS"))
            {
                states.Add(new USState()
                {
                    Name = "MISSISSIPPI",
                    Abbreviation = "MS"
                });
            }

            if (text.Contains("MISSOURI") || text.Contains("MO"))
            {
                states.Add(new USState()
                {
                    Name = "MISSOURI",
                    Abbreviation = "MO"
                });
            }

            if (text.Contains("MONTANA") || text.Contains("MT"))
            {
                states.Add(new USState()
                {
                    Name = "MONTANA",
                    Abbreviation = "MT"
                });
            }

            if (text.Contains("NEBRASKA") || text.Contains("NE"))
            {
                states.Add(new USState()
                {
                    Name = "NEBRASKA",
                    Abbreviation = "NE"
                });
            }

            if (text.Contains("NEVADA") || text.Contains("NV"))
            {
                states.Add(new USState()
                {
                    Name = "NEVADA",
                    Abbreviation = "NV"
                });
            }

            if (text.Contains("NEW HAMPSHIRE") || text.Contains("NH"))
            {
                states.Add(new USState()
                {
                    Name = "NEW HAMPSHIRE",
                    Abbreviation = "NH"
                });
            }

            if (text.Contains("NEW JERSEY") || text.Contains("NJ"))
            {
                states.Add(new USState()
                {
                    Name = "NEW JERSEY",
                    Abbreviation = "NJ"
                });
            }

            if (text.Contains("NEW MEXICO") || text.Contains("NM"))
            {
                states.Add(new USState()
                {
                    Name = "NEW MEXICO",
                    Abbreviation = "NM"
                });
            }

            if (text.Contains("NEW YORK") || text.Contains("NY"))
            {
                states.Add(new USState()
                {
                    Name = "NEW YORK",
                    Abbreviation = "NY"
                });
            }

            if (text.Contains("NORTH CAROLINA") || text.Contains("NC"))
            {
                states.Add(new USState()
                {
                    Name = "NORTH CAROLINA",
                    Abbreviation = "NC"
                });
            }

            if (text.Contains("NORTH DAKOTA") || text.Contains("ND"))
            {
                states.Add(new USState()
                {
                    Name = "NORTH DAKOTA",
                    Abbreviation = "ND"
                });
            }

            if (text.Contains("NORTHERN MARIANA ISLANDS") || text.Contains("MP"))
            {
                states.Add(new USState()
                {
                    Name = "NORTHERN MARIANA ISLANDS",
                    Abbreviation = "MP"
                });
            }

            if (text.Contains("OHIO") || text.Contains("OH"))
            {
                states.Add(new USState()
                {
                    Name = "OHIO",
                    Abbreviation = "OH"
                });
            }

            if (text.Contains("OKLAHOMA") || text.Contains("OK"))
            {
                states.Add(new USState()
                {
                    Name = "OKLAHOMA",
                    Abbreviation = "OK"
                });
            }

            if (text.Contains("OREGON") || text.Contains("OR"))
            {
                states.Add(new USState()
                {
                    Name = "OREGON",
                    Abbreviation = "OR"
                });
            }

            if (text.Contains("PALAU") || text.Contains("PW"))
            {
                states.Add(new USState()
                {
                    Name = "PALAU",
                    Abbreviation = "PW"
                });
            }

            if (text.Contains("PENNSYLVANIA") || text.Contains("PA"))
            {
                states.Add(new USState()
                {
                    Name = "PENNSYLVANIA",
                    Abbreviation = "PA"
                });
            }

            if (text.Contains("PUERTO RICO") || text.Contains("PR"))
            {
                states.Add(new USState()
                {
                    Name = "PUERTO RICO",
                    Abbreviation = "PR"
                });
            }

            if (text.Contains("RHODE ISLAND") || text.Contains("RI"))
            {
                states.Add(new USState()
                {
                    Name = "RHODE ISLAND",
                    Abbreviation = "RI"
                });
            }

            if (text.Contains("SOUTH CAROLINA") || text.Contains("SC"))
            {
                states.Add(new USState()
                {
                    Name = "SOUTH CAROLINA",
                    Abbreviation = "SC"
                });
            }

            if (text.Contains("SOUTH DAKOTA") || text.Contains("SD"))
            {
                states.Add(new USState()
                {
                    Name = "SOUTH DAKOTA",
                    Abbreviation = "SD"
                });
            }

            if (text.Contains("TENNESSEE") || text.Contains("TN"))
            {
                states.Add(new USState()
                {
                    Name = "TENNESSEE",
                    Abbreviation = "TN"
                });
            }

            if (text.Contains("TEXAS") || text.Contains("TX"))
            {
                states.Add(new USState()
                {
                    Name = "TEXAS",
                    Abbreviation = "TX"
                });
            }

            if (text.Contains("UTAH") || text.Contains("UT"))
            {
                states.Add(new USState()
                {
                    Name = "UTAH",
                    Abbreviation = "UT"
                });
            }

            if (text.Contains("VERMONT") || text.Contains("VT"))
            {
                states.Add(new USState()
                {
                    Name = "VERMONT",
                    Abbreviation = "VT"
                });
            }

            if (text.Contains("VIRGIN ISLANDS") || text.Contains("VI"))
            {
                states.Add(new USState()
                {
                    Name = "VIRGIN ISLANDS",
                    Abbreviation = "VI"
                });
            }

            if (text.Contains("VIRGINIA") || text.Contains("VA"))
            {
                states.Add(new USState()
                {
                    Name = "VIRGINIA",
                    Abbreviation = "VA"
                });
            }

            if (text.Contains("WASHINGTON") || text.Contains("WA"))
            {
                states.Add(new USState()
                {
                    Name = "WASHINGTON",
                    Abbreviation = "WA"
                });
            }

            if (text.Contains("WEST VIRGINIA") || text.Contains("WV"))
            {
                states.Add(new USState()
                {
                    Name = "WEST VIRGINIA",
                    Abbreviation = "WV"
                });
            }

            if (text.Contains("WISCONSIN") || text.Contains("WI"))
            {
                states.Add(new USState()
                {
                    Name = "WISCONSIN",
                    Abbreviation = "WI"
                });
            }

            if (text.Contains("WYOMING") || text.Contains("WY"))
            {
                states.Add(new USState()
                {
                    Name = "WYOMING",
                    Abbreviation = "WY"
                });
            }

            return states;
        }

        public static string GetStateByAbbreviation(string name)
        {
            switch (name.ToUpper())
            {
                case "ALABAMA":
                    return "AL";

                case "ALASKA":
                    return "AK";

                case "AMERICAN SAMOA":
                    return "AS";

                case "ARIZONA":
                    return "AZ";

                case "ARKANSAS":
                    return "AR";

                case "CALIFORNIA":
                    return "CA";

                case "COLORADO":
                    return "CO";

                case "CONNECTICUT":
                    return "CT";

                case "DELAWARE":
                    return "DE";

                case "DISTRICT OF COLUMBIA":
                    return "DC";

                case "FEDERATED STATES OF MICRONESIA":
                    return "FM";

                case "FLORIDA":
                    return "FL";

                case "GEORGIA":
                    return "GA";

                case "GUAM":
                    return "GU";

                case "HAWAII":
                    return "HI";

                case "IDAHO":
                    return "ID";

                case "ILLINOIS":
                    return "IL";

                case "INDIANA":
                    return "IN";

                case "IOWA":
                    return "IA";

                case "KANSAS":
                    return "KS";

                case "KENTUCKY":
                    return "KY";

                case "LOUISIANA":
                    return "LA";

                case "MAINE":
                    return "ME";

                case "MARSHALL ISLANDS":
                    return "MH";

                case "MARYLAND":
                    return "MD";

                case "MASSACHUSETTS":
                    return "MA";

                case "MICHIGAN":
                    return "MI";

                case "MINNESOTA":
                    return "MN";

                case "MISSISSIPPI":
                    return "MS";

                case "MISSOURI":
                    return "MO";

                case "MONTANA":
                    return "MT";

                case "NEBRASKA":
                    return "NE";

                case "NEVADA":
                    return "NV";

                case "NEW HAMPSHIRE":
                    return "NH";

                case "NEW JERSEY":
                    return "NJ";

                case "NEW MEXICO":
                    return "NM";

                case "NEW YORK":
                    return "NY";

                case "NORTH CAROLINA":
                    return "NC";

                case "NORTH DAKOTA":
                    return "ND";

                case "NORTHERN MARIANA ISLANDS":
                    return "MP";

                case "OHIO":
                    return "OH";

                case "OKLAHOMA":
                    return "OK";

                case "OREGON":
                    return "OR";

                case "PALAU":
                    return "PW";

                case "PENNSYLVANIA":
                    return "PA";

                case "PUERTO RICO":
                    return "PR";

                case "RHODE ISLAND":
                    return "RI";

                case "SOUTH CAROLINA":
                    return "SC";

                case "SOUTH DAKOTA":
                    return "SD";

                case "TENNESSEE":
                    return "TN";

                case "TEXAS":
                    return "TX";

                case "UTAH":
                    return "UT";

                case "VERMONT":
                    return "VT";

                case "VIRGIN ISLANDS":
                    return "VI";

                case "VIRGINIA":
                    return "VA";

                case "WASHINGTON":
                    return "WA";

                case "WEST VIRGINIA":
                    return "WV";

                case "WISCONSIN":
                    return "WI";

                case "WYOMING":
                    return "WY";
            }

            return null;
        }

        public static string GetAbbreviationByStateName(string abbreviation)
        {
            switch (abbreviation.ToUpper())
            {
                case "AL":
                    return "ALABAMA";

                case "AK":
                    return "ALASKA";

                case "AS":
                    return "AMERICAN SAMOA";

                case "AZ":
                    return "ARIZONA";

                case "AR":
                    return "ARKANSAS";

                case "CA":
                    return "CALIFORNIA";

                case "CO":
                    return "COLORADO";

                case "CT":
                    return "CONNECTICUT";

                case "DE":
                    return "DELAWARE";

                case "DC":
                    return "DISTRICT OF COLUMBIA";

                case "FM":
                    return "FEDERATED STATES OF MICRONESIA";

                case "FL":
                    return "FLORIDA";

                case "GA":
                    return "GEORGIA";

                case "GU":
                    return "GUAM";

                case "HI":
                    return "HAWAII";

                case "ID":
                    return "IDAHO";

                case "IL":
                    return "ILLINOIS";

                case "IN":
                    return "INDIANA";

                case "IA":
                    return "IOWA";

                case "KS":
                    return "KANSAS";

                case "KY":
                    return "KENTUCKY";

                case "LA":
                    return "LOUISIANA";

                case "ME":
                    return "MAINE";

                case "MH":
                    return "MARSHALL ISLANDS";

                case "MD":
                    return "MARYLAND";

                case "MA":
                    return "MASSACHUSETTS";

                case "MI":
                    return "MICHIGAN";

                case "MN":
                    return "MINNESOTA";

                case "MS":
                    return "MISSISSIPPI";

                case "MO":
                    return "MISSOURI";

                case "MT":
                    return "MONTANA";

                case "NE":
                    return "NEBRASKA";

                case "NV":
                    return "NEVADA";

                case "NH":
                    return "NEW HAMPSHIRE";

                case "NJ":
                    return "NEW JERSEY";

                case "NM":
                    return "NEW MEXICO";

                case "NY":
                    return "NEW YORK";

                case "NC":
                    return "NORTH CAROLINA";

                case "ND":
                    return "NORTH DAKOTA";

                case "MP":
                    return "NORTHERN MARIANA ISLANDS";

                case "OH":
                    return "OHIO";

                case "OK":
                    return "OKLAHOMA";

                case "OR":
                    return "OREGON";

                case "PW":
                    return "PALAU";

                case "PA":
                    return "PENNSYLVANIA";

                case "PR":
                    return "PUERTO RICO";

                case "RI":
                    return "RHODE ISLAND";

                case "SC":
                    return "SOUTH CAROLINA";

                case "SD":
                    return "SOUTH DAKOTA";

                case "TN":
                    return "TENNESSEE";

                case "TX":
                    return "TEXAS";

                case "UT":
                    return "UTAH";

                case "VT":
                    return "VERMONT";

                case "VI":
                    return "VIRGIN ISLANDS";

                case "VA":
                    return "VIRGINIA";

                case "WA":
                    return "WASHINGTON";

                case "WV":
                    return "WEST VIRGINIA";

                case "WI":
                    return "WISCONSIN";

                case "WY":
                    return "WYOMING";
            }

            return null;
        }
    }

    public class USState
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}