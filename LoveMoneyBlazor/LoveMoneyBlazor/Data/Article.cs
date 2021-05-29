using System;

namespace LoveMoneyBlazor.Data
{
    public class Article
    {
        public string Title { get; set; }
        public string Subheading { get; set; }
        //TODO : Link to topics model from home page
        public string Topic { get; set; }
        public string BackgroundImage { get; set; }
        public string Description { get; set; }
    }
}
