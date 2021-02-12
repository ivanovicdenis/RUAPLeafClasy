// This code requires the Nuget package Microsoft.AspNet.WebApi.Client to be installed.
// Instructions for doing this in Visual Studio:
// Tools -> Nuget Package Manager -> Package Manager Console
// Install-Package Microsoft.AspNet.WebApi.Client

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CallRequestResponseService
{

    public class StringTable
    {
        public string[] ColumnNames { get; set; }
        public string[,] Values { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InvokeRequestResponseService().Wait();
        }

        static async Task InvokeRequestResponseService()
        {
            using (var client = new HttpClient())
            {
                // u podatciCopyPaste samo dodaješ podatke koje oćeš isprobat u formatu {{podatci1}, {podatci2},....}
                double[,] podatciCopyPaste = new double[,] { {27,111,0,0,0.001953,0.029297,0.11133,0,0,0,0.029297,0,0,0,0,0.023438,0.001953,0,0.005859,0,0.11719,0.003906,0,0,0.019531,0.017578,0.011719,0.011719,0.015625,0.041016,0,0.009766,0.035156,0.050781,0,0.003906,0,0,0.003906,0.001953,0.003906,0.007812,0.17969,0.007812,0,0.021484,0,0.029297,0.001953,0,0.054688,0,0,0.009766,0.009766,0.035156,0,0,0,0.007812,0.005859,0.060547,0.003906,0.007812,0.001953,0.003906,0.0011448,0.0010666,0.00099556,0.00092949,0.00087691,0.00084537,0.00081038,0.00078007,0.00076342,0.00074886,0.00073552,0.00072681,0.00071813,0.0007155,0.00071266,0.00070683,0.00069732,0.00069564,0.0006992,0.00070635,0.0007099,0.000721,0.00072663,0.00073689,0.0007597,0.00078228,0.00079956,0.0008285,0.00085514,0.00088472,0.00091699,0.00094766,0.0009681,0.00096525,0.0009356,0.00089393,0.00085251,0.00081467,0.0007849,0.00076042,0.00074401,0.00072258,0.00070355,0.00068658,0.0006727,0.00066767,0.00066309,0.00066297,0.00067193,0.00067734,0.00069616,0.00071134,0.00073405,0.00075179,0.00077728,0.00079007,0.00080324,0.00083197,0.00085598,0.00087554,0.0009023,0.00094291,0.0010191,0.0010989,0.003906,0,0.007812,0,0.13281,0,0.000977,0.026367,0,0,0,0.37793,0,0,0,0,0,0,0.000977,0.001953,0,0,0.068359,0,0.001953,0,0.000977,0.017578,0.004883,0,0.037109,0,0,0.008789,0,0,0,0.055664,0.003906,0,0,0,0,0,0.039062,0.051758,0.007812,0.037109,0,0,0,0,0,0.000977,0.012695,0,0.079102,0,0,0,0,0,0,0.019531
 } };
                string[,] podatci = new string[podatciCopyPaste.GetLength(0), podatciCopyPaste.GetLength(1)];

                for (int i = 0; i < podatciCopyPaste.GetLength(0); i++)
                {
                    for (int j = 0; j < podatciCopyPaste.GetLength(1); j++)
                    {
                        podatci[i,j] = podatciCopyPaste[i,j].ToString("G",CultureInfo.InvariantCulture);
                    }
                }
                int ig = 0;
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"id", "species", "margin1", "margin2", "margin3", "margin4", "margin5", "margin6", "margin7", "margin8", "margin9", "margin10", "margin11", "margin12", "margin13", "margin14", "margin15", "margin16", "margin17", "margin18", "margin19", "margin20", "margin21", "margin22", "margin23", "margin24", "margin25", "margin26", "margin27", "margin28", "margin29", "margin30", "margin31", "margin32", "margin33", "margin34", "margin35", "margin36", "margin37", "margin38", "margin39", "margin40", "margin41", "margin42", "margin43", "margin44", "margin45", "margin46", "margin47", "margin48", "margin49", "margin50", "margin51", "margin52", "margin53", "margin54", "margin55", "margin56", "margin57", "margin58", "margin59", "margin60", "margin61", "margin62", "margin63", "margin64", "shape1", "shape2", "shape3", "shape4", "shape5", "shape6", "shape7", "shape8", "shape9", "shape10", "shape11", "shape12", "shape13", "shape14", "shape15", "shape16", "shape17", "shape18", "shape19", "shape20", "shape21", "shape22", "shape23", "shape24", "shape25", "shape26", "shape27", "shape28", "shape29", "shape30", "shape31", "shape32", "shape33", "shape34", "shape35", "shape36", "shape37", "shape38", "shape39", "shape40", "shape41", "shape42", "shape43", "shape44", "shape45", "shape46", "shape47", "shape48", "shape49", "shape50", "shape51", "shape52", "shape53", "shape54", "shape55", "shape56", "shape57", "shape58", "shape59", "shape60", "shape61", "shape62", "shape63", "shape64", "texture1", "texture2", "texture3", "texture4", "texture5", "texture6", "texture7", "texture8", "texture9", "texture10", "texture11", "texture12", "texture13", "texture14", "texture15", "texture16", "texture17", "texture18", "texture19", "texture20", "texture21", "texture22", "texture23", "texture24", "texture25", "texture26", "texture27", "texture28", "texture29", "texture30", "texture31", "texture32", "texture33", "texture34", "texture35", "texture36", "texture37", "texture38", "texture39", "texture40", "texture41", "texture42", "texture43", "texture44", "texture45", "texture46", "texture47", "texture48", "texture49", "texture50", "texture51", "texture52", "texture53", "texture54", "texture55", "texture56", "texture57", "texture58", "texture59", "texture60", "texture61", "texture62", "texture63", "texture64"},
                                Values = podatci
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "XNl1MK3yxQV7Z/L+covR9ii07h/ZZpVxHoAtIGfWruMubjajrWFwFvO4CUouiG0TxYX7eVT3aLknck7fqzmhig=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/0c1678408c4c4bec9af2914f741c445e/services/f8ebcfcc52344250bf19cbc1fa8810a8/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }
    }
}
