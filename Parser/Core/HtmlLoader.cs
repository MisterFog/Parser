
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace Parser.Core
{
    //Назначение этого класса - загружать исходный код страници из указанных настроек парсера
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        //открытый конструктор для класса принемающий объект
        public HtmlLoader(IParserSetings setings)
        {
            //инициализация поля client
            client = new HttpClient();       
            //строим ссылку для запросса url
            url = $"{setings.BaseUrl}/{setings.Prefix}/";//$...интерполированная строка
        }
        //открытый асинхронный метод который будет возвращать string в аргументе будет принимать id страницы
        public async Task<string> GetSourceByPageId(int id)
        {
            //редактируем url для запросов
            var currentUrl = url.Replace("{CurrentId}",id.ToString());

            //переменная будет принимать результат метода GetAsync по указанной ссылки
            var response = await client.GetAsync(currentUrl);
            string source = null;//в эту переменную будем засовывать исходный код страницы

            if(response !=null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
