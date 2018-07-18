using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    //обобщённый класс
    class ParserWorker<T> where T:class
    {
        IParser<T> parser;
        IParserSetings parserSetings;

        HtmlLoader loader;
        bool isActive;

        //публичные свойства
        #region Properties

            public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }
            public IParserSetings Setings
        {
            get
            {
                return parserSetings;
            }
            set
            {
                parserSetings = value;
                loader = new HtmlLoader(value);
            }
        }
            public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        //события
        //возвращает спаршиные из этарации данные, в аргументах ссылка на парсер и сами данные
        public event Action<object, T> OnNewData;
        //отвечает за информирование завершение работы парсера
        public event Action<object> OnCompleted;

        //конструктор реализующий интерфейс Iparser
        public ParserWorker(IParser<T> parser)
        {
            //присваеваем значение аргумента полю
            this.parser = parser;

        }
        //конструктор реализующий интерфейс Iparser и принимающий настройки парсера        
        public ParserWorker(IParser<T> parser,IParserSetings parserSetings):this(parser)//для того чтобы не дублировать код вызовем первый конструктор с аргументом parser
        {
            this.parserSetings = parserSetings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        //закрытый асинхр метод, который контролирует процесс парсинга
        private async void Worker()
        {
            //прогоняем цикл от стартовой до конечной настроек
            for (int i = parserSetings.StartPoint; i <= parserSetings.EndPoint;i++)
            {
                if (!isActive)
                {
                    //вызов события информирует о конце работы парсера
                    OnCompleted?.Invoke(this);
                    return;
                }
                //получаем исходный код страници с индексом из цикла
                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();

                //спарсим асинхронно код и получим док с которым можно работать
                var document = await domParser.ParseAsync(source);

                //передаём док в парсер и записываем в переменную
                var result = parser.Parse(document);

                //вызов события которрое передаёт ссылку и результат
                OnNewData?.Invoke(this,result);
            }

            //вызов события информирует о конце работы парсера
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
