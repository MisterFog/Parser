using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//отвечает за настройки парсера
namespace Parser.Core
{
    interface IParserSetings
    {
        string BaseUrl { get; set; } //хранит url сайта, который подвергается парсингу
        string Prefix { get; set; }
        int StartPoint { get; set; } //указывает с какой страницы начало парсинга
        int EndPoint { get; set; } //конечный индекс страници для парсинга
    }
}
