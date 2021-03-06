﻿
namespace Parser.Core.Habra
{
    class HabraSetings : IParserSetings
    {
        public HabraSetings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habrahabr.ru/";        

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
