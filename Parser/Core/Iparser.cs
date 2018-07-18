using AngleSharp.Dom.Html;

namespace Parser.Core
{
    interface IParser<T> where T:class //обобщённый интерфейс - это значит, что классы которые его будут реализовывать будут возвращать данные любого сылочного типа
    {
        T Parse(IHtmlDocument document);//этот тип при реализации в классе будет заменяться на любой другой тип
    }
}
