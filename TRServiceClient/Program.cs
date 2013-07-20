namespace TRServiceClient
{
    using System;
    using System.Text;
    using System.ServiceModel;
    using RetailTx;

    class Program
    {
        static void Main(string[] args)
        {
            TestService();

            Console.WriteLine("Th-th-that's all, folks!");
            Console.ReadLine();
        }

        private static void TestService()
        {
            var URL = "http://64.141.202.5:9009/GuestInfoTransactions";
            var loyaltyNumber = "10407039081";
            var source = "OpenTable";
            var searchType = "searchByTR";
            var transactionId = "12345678";

            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Name = "GuestInfoTxns_Soap_PortEndpointBinding";
            EndpointAddress endpointAddress = new EndpointAddress(URL);
            InfoGuestTrnx_HTTP_PortClient client = new InfoGuestTrnx_HTTP_PortClient(binding, endpointAddress);

            var request = new GuestInfoRequest()
            {
                accountNumber = loyaltyNumber,
                source = source,
                searchType = searchType,
                transactionID = transactionId
            };

            DisplayRequest(request);

            var response = client.getGuestInfo(request);

            DisplayResponse(response);
        }

        private static void DisplayResponse(GuestInfoResponse response)
        {
            var s = new StringBuilder();
            s.AppendLine("{*** RESPONSE ***}");
            if (response == null)
                s.AppendLine("<NULL>");
            else
            {
                s.Append("transactionID = ");
                s.AppendLine(response.transactionID);
                s.Append("resultCode = ");
                s.AppendLine(response.resultCode);
                s.Append("resultMessage = ");
                s.AppendLine(response.resultMessage);
                if (response.resultStatus != null)
                {
                    s.Append("resultStatus.STAT = ");
                    s.AppendLine(response.resultStatus.STAT.ToString());
                }
                else
                {
                    s.AppendLine("resultStatus = <NULL>");
                }
                var count = (response.guests != null) ? response.guests.Length : 0;
                s.Append("Number of Guests = ");
                s.AppendLine(count.ToString());
                for (int i = 0; i < count; ++i)
                {
                    s.AppendLine("------------------");
                    s.Append("Guest # ");
                    s.AppendLine((i + 1).ToString());
                    s.Append("accountNumber = ");
                    s.AppendLine(response.guests[i].accountNumber);
                    s.Append("firstName = ");
                    s.AppendLine(response.guests[i].firstName);
                    s.Append("lastName = ");
                    s.AppendLine(response.guests[i].lastName);
                    if (response.guests[i].address != null)
                    {
                        s.Append("address.address1 = ");
                        s.AppendLine(response.guests[i].address.address1);
                        s.Append("address.address2 = ");
                        s.AppendLine(response.guests[i].address.address2);
                        s.Append("address.city = ");
                        s.AppendLine(response.guests[i].address.city);
                        s.Append("address.countryCode = ");
                        s.AppendLine(response.guests[i].address.countryCode);
                        s.Append("address.postalCode = ");
                        s.AppendLine(response.guests[i].address.postalCode);
                        s.Append("address.stateCode = ");
                        s.AppendLine(response.guests[i].address.stateCode);
                    }
                    else
                    {
                        s.AppendLine("address = <NULL>");
                    }
                    s.Append("email = ");
                    s.AppendLine(response.guests[i].email);
                    s.Append("phone = ");
                    s.AppendLine(response.guests[i].phone);
                    if (response.guests[i].tier != null)
                    {
                        s.Append("tier.tierCode = ");
                        s.AppendLine(response.guests[i].tier.tierCode);
                        s.Append("tier.tierDescription = ");
                        s.AppendLine(response.guests[i].tier.tierDescription);
                    }
                    else
                    {
                        s.AppendLine("tier = <NULL>");
                    }
                    s.AppendLine("------------------");
                }
            }
            Console.WriteLine(s.ToString());
        }

        private static void DisplayRequest(GuestInfoRequest request)
        {
            var s = new StringBuilder();
            s.AppendLine("{*** REQUEST ***}");
            if (request == null)
                s.AppendLine("<NULL>");
            else
            {
                s.Append("accountNumber = ");
                s.AppendLine(request.accountNumber);
                s.Append("transactionID = ");
                s.AppendLine(request.transactionID);
                s.Append("source = ");
                s.AppendLine(request.source);
                s.Append("searchType = ");
                s.AppendLine(request.searchType);
            }
            Console.WriteLine(s.ToString());
        }
    }
}
