using My_Test_App_For_GoAir.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace My_Test_App_For_GoAir
{
    class Program
    {
        public static string ConfigPath
        {
            get
            {
                return ConfigurationManager.AppSettings["configFiles"];
            }
        }

        //public static void Main(string[] args)
        //{
            #region
            //string key = "GoAir_LoginName";
            //string value = string.Empty;
            //string officeID = "GoAirLoginName12";// "APITRVBOUTON";//"GoAirLoginName";//"GoAirLoginName";OTI011

            //string keyPrefix = null;
            //if (pickPrefixAccToOfficeId(officeID, ref keyPrefix))
            //    Console.WriteLine(officeID);
            //else
            //    Console.WriteLine("Will Pick From Active Supplier ID");

            //if (ConfigurationSystem.GoAirNavitaireConfig.ContainsKey(key) &&
            //    !string.IsNullOrEmpty(ConfigurationSystem.GoAirNavitaireConfig[key]))
            //    value = Convert.ToString(ConfigurationSystem.GoAirNavitaireConfig[key]);

            //var keysWithMatchingValues = ConfigurationSystem.GoAirNavitaireConfig.Where(p => p.Value == officeID).Select(p => p.Key);

            //if (keysWithMatchingValues == null || keysWithMatchingValues.Count() == 0)
            //    return;

            //string test = string.Empty;
            //foreach (var keytest in keysWithMatchingValues)
            //{
            //    test = keytest.ToString();
            //    break;
            //    //Console.WriteLine(keytest);
            //}

            //var keyNode = test.Split('_')[1];
            ////test.Split(new string[] { "_","_" }, StringSplitOptions.RemoveEmptyEntries);

            //if (keyNode.ToLower().Equals("loginname"))
            //    keyNode = "";

            //#region
            ////var xmlDoc = new XmlDocument();
            ////xmlDoc.Load(ConfigPath + "GoAirNavitaire.config.xml");
            ////XmlNodeList uapiGoAirList = xmlDoc.SelectNodes("config/GoAir");
            ////if(ConfigurationSystem.)

            ////XmlTextReader reader = new XmlTextReader("books.xml");
            ////while (reader.Read())
            ////{
            ////    switch (reader.NodeType)
            ////    {
            ////        case XmlNodeType.Element: // The node is an element.
            ////            Console.Write("<" + reader.Name);
            ////            Console.WriteLine(">");
            ////            break;
            ////        case XmlNodeType.Text: //Display the text in each element.
            ////            Console.WriteLine(reader.Value);
            ////            break;
            ////        case XmlNodeType.EndElement: //Display the end of the element.
            ////            Console.Write("</" + reader.Name);
            ////            Console.WriteLine(">");
            ////            break;
            ////    }
            ////}
            //#endregion
            //Console.ReadLine();
            //Console.WriteLine(value);
            #endregion

            //string cancelMessages = string.Empty;
            //if (ConfigurationSystem.BookingEngineApiConfig.TryGetValue("CancellationErrorMessage", out cancelMessages) &&
            //          !string.IsNullOrEmpty(cancelMessages))
            //{
            //    var cancelMsg = "Pnr has been already cancelled.";//cancelMessages.ToLower().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            //    var cancellMsg = cancelMessages.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            //    foreach (var msg in cancellMsg)
            //    {
            //        if (cancelMsg.ToLower().Contains(msg.ToLower()))
            //        {
            //            //sendEmail = false;
            //            break;
            //        }
            //    }

            //    //if (cancelMsg.ToLower().Contains(cancelMessages.ToLower()))
            //    //{
            //    //    //sendEmail = false;
            //    //    //break;
            //    //    var responsejson = string.Empty;
            //    //    responsejson = File.ReadAllText(@"E:\test\Test.txt");
            //    //    var rest = File.ReadAllText(@"E:\test\TestCopymultiplevalue.txt");
            //    //    decimal updatedFare = ReadBusUpdateFareResponse(responsejson, rest, out decimal previousFare);
            //    //}

            //}

            //var responsejson = string.Empty;
            //responsejson = File.ReadAllText(@"E:\test\Test.txt");
            //var rest = File.ReadAllText(@"E:\test\TestCopymultiplevalue.txt");
            //decimal updatedFare = ReadBusUpdateFareResponse(responsejson, rest, out decimal previousFare);
            //var couponReq = BuildCouponRequestXML();
            //var couponRes = "";
        //}

        private static decimal ReadBusUpdateFareResponse(string busSearchResponsejson, string rest, out decimal previousFare)
        {
            decimal updatedFare = 0;
            JToken results = null;
            JToken resultsRest = null;
            var isValidJson = ReadAndValidateJson(busSearchResponsejson, ref results);
            var isValidJsonRest = ReadAndValidateJson(rest, ref resultsRest);
            dynamic response = results;
            dynamic responseRest = resultsRest;
            previousFare = response.previousFare;

            if (isValidJson)
            {
                decimal ansFare = response.asnFare;
                decimal bookingFee = response.bookingFee;
                decimal convenienceFee = 0;
                decimal otherCharges = response.otherCharges;
                decimal reservationFee = 0;
                decimal tollFee = response.tollFee;
                decimal basicFare = 0;
                decimal serviceTax = 0;
                /*Refer this mail for this chnage -> Re: [Ticket#103891733] Red Bus Test URL For Testing Purpose */
                if (response?.fareBreakup?.fareBreakups != null)
                {
                    foreach (var fareBreakUp in response.fareBreakup.fareBreakups)
                    {
                        if (response.fareBreakup.fareBreakups is JArray)
                        {
                            foreach (var priceBreakUp in fareBreakUp.customerPriceBreakUp)
                            {
                                CalculateComponentPrice(ref convenienceFee, ref reservationFee, ref basicFare, ref serviceTax, priceBreakUp);
                            }
                        }
                        else
                        {
                            var customerPriceBreakUp = response.fareBreakup.fareBreakups.customerPriceBreakUp;
                            foreach (var priceBreakUp in customerPriceBreakUp)
                            {
                                CalculateComponentPrice(ref convenienceFee, ref reservationFee, ref basicFare, ref serviceTax, priceBreakUp);
                            }
                        }
                    }
                }

                updatedFare = basicFare + convenienceFee + serviceTax + reservationFee + bookingFee + ansFare;
            }
            return updatedFare;
        }

        private static void CalculateComponentPrice(ref decimal convenienceFee, ref decimal reservationFee, ref decimal basicFare, ref decimal serviceTax, dynamic priceBreakUp)
        {
            string componentName = priceBreakUp.componentName;
            switch (componentName.ToUpper())
            {
                case "BASIC_FARE":
                    basicFare += Convert.ToDecimal(priceBreakUp.value);
                    break;
                case "CONVENIENCE_FEE":
                    convenienceFee += Convert.ToDecimal(priceBreakUp.value);
                    break;
                case "RESERVATION_FEE":
                    reservationFee += Convert.ToDecimal(priceBreakUp.value);
                    break;
                case "SERVICE_TAX":
                    serviceTax += Convert.ToDecimal(priceBreakUp.value);
                    break;
            }
        }

        private static bool ReadAndValidateJson(string jsonString, ref JToken result)
        {
            try
            {
                result = JObject.Parse(jsonString);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private static bool pickPrefixAccToOfficeId(string officeId, ref string keyPrefix)
        {
            if (string.IsNullOrWhiteSpace(officeId))
                return false;

            List<string> keysWithMatchingValues = ConfigurationSystem.AirAsiaConfig.Where(p => p.Value.ToLower() == officeId.ToLower()).Select(p => p.Key).ToList();
            List<string> testMatch;
            testMatch = ConfigurationSystem.GoAirNavitaireConfig.Where(p => p.Value.ToLower() == officeId.ToLower() && p.Key.ToLower().Contains("loginname")).Select(p => p.Key).ToList();

            if (keysWithMatchingValues == null || keysWithMatchingValues.Count == 0)
            {
                return false;
            }

            //if (testMatch == null || testMatch.Count() == 0)
            //{
            //    return false;
            //}

            //string keyName = testMatch.First();

            string key = keysWithMatchingValues.First().Replace("GoAir_", "");  //keysWithMatchingValues.First(); //string.Empty;testMatch

            //key = key.Replace("GoAir_", "");

            //if (key.ToLower().Contains("goair_"))
            //{
            //    var testString = new StringBuilder(key);
            //    testString.Remove(0, 6);
            //    key = testString.ToString();
            //    //key.Replace(key, "");
            //}

            if (key.ToLower().Equals("loginname") || key.ToLower().Equals("username"))
            {
                keyPrefix = string.Empty;
                return true;
            }

            keyPrefix = key.Split('_')[0] + "_";


            return true;
        }

        private static string BuildCouponRequestXML()
        {
            var strBuild = new StringBuilder();
            var requestXml = XmlWriter.Create(strBuild);

            //requestXml.WriteStartElement("AuthorizeCoupon", "http://tempuri.org/");
            //requestXml.WriteStartElement("value");
            //requestXml.WriteAttributeString("xmlns", "d4p1", null, "http://schemas.datacontract.org/2004/07/TBOCouponService");
            //requestXml.WriteAttributeString("xmlns", "i", null, "http://www.w3.org/2001/XMLSchema-instance");
            //requestXml.WriteStartElement("d4p1","AgencyId",null);
            //requestXml.WriteString("finally");
            ////requestXml.WriteElementString("d4p1", "AgencyId", "second");
            //requestXml.WriteEndElement();
            //requestXml.WriteEndElement();
            //requestXml.WriteEndElement();
            //requestXml.Close();

            requestXml.WriteStartElement("tem", "AuthorizeCoupon", "http://tempuri.org/");
            requestXml.WriteStartElement("tem", "value", null);
            requestXml.WriteAttributeString("xmlns", "tboc", null, "http://schemas.datacontract.org/2004/07/TBOCouponService");
            requestXml.WriteAttributeString("xmlns", "tem", null, "http://tempuri.org/");
            requestXml.WriteStartElement("tboc", "AgencyId", null);
            requestXml.WriteString("Agency");
            requestXml.WriteEndElement();

            requestXml.WriteStartElement("tboc", "CouponCode", null);
            requestXml.WriteString("coupon");
            requestXml.WriteEndElement();

            requestXml.WriteStartElement("tboc", "MemberId", null);
            requestXml.WriteString("memberid");
            requestXml.WriteEndElement();

            requestXml.WriteStartElement("tboc", "SiteId", null);
            requestXml.WriteString("Siteid");
            requestXml.WriteEndElement();

            requestXml.WriteStartElement("tboc", "TokenId", null);
            requestXml.WriteString("Tokenid");
            requestXml.WriteEndElement();

            requestXml.WriteEndElement();
            requestXml.WriteEndElement();

            requestXml.Close();
            return strBuild.ToString();
        }
    }
}
