namespace Inheritance
{
    public class Text : PresentationObject  // Child class  : Parent class -- Inheritance 
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("We added a link to " + url);

        }


    }
}
