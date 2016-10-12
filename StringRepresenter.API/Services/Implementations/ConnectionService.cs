using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StringRepresenter.API.Model;

namespace StringRepresenter.API.Services.Implementations
{
	public class ConnectionService : IConnectionService
	{
		public async Task<List<Offer>> GetDataFromUrl(string url)
		{
			XDocument doc;
			using (var httpClient = new HttpClient())
			{
				var message = await httpClient.GetAsync(url).ConfigureAwait(false);

				byte[] buffer = await message.Content.ReadAsByteArrayAsync();

				string xml = Encoding.GetEncoding("windows-1251").GetString(buffer, 0, buffer.Length);
				doc = XDocument.Parse(xml);
				doc.Declaration = new XDeclaration("1.0", "utf-8", null);

			}

			return doc.ParseOffers();
		}
	}
}
