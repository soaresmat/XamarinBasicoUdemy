using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace _01_Dicas_ServicoCEP
{
    class ServicoCEP
    {
        private static string UrlBase = "https://viacep.com.br/ws/{0}/json/";

        public async static Task<string> BuscaCEP(string cep)
        {
            string URL = string.Format(UrlBase, cep);

            HttpClient http = new HttpClient();
            string json = await http.GetStringAsync(URL);

            dynamic objectCEP = JsonConvert.DeserializeObject<dynamic>(json);

            string resultado = string.Format("Localidade: {0}, UF: {1}, Logradouro: {2}, CEP: {3}", objectCEP.localidade, objectCEP.uf, objectCEP.logradouro, objectCEP.cep);

            return resultado;
        }
    }
}
