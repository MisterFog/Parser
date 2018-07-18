using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser.Core.Habra
{
    class HabraParser : IParser<string[]>//реализуем интерфейс IParser с типом массив string
    {
        //Получаем заголовки статей с  сайта Habra
        public string[] Parse(IHtmlDocument document)
        {
            //преобразование к нормальному виду
            var list = new List<string>();

            //при помощи document и метода QuerySelectorAll мы можем получить из документа все теги определённого типа
            //берём значение тега <a></a> и проверяем его на то что у него присутствует элемент Class и оно должно содержать значение "post__title_link"
            var items = document.QuerySelectorAll("a").Where(item=>item.ClassName != null && item.ClassName.Contains("post__title_link"));

            foreach (var item in items)//пройдёмся по каждому элементу из items 
            {
                list.Add(item.TextContent);//TextContent-содержет заголовок статьи
            }

            return list.ToArray();//преобраговываем в массив
        }
    }
}
