using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
namespace _5.ReplaceHTMLtags
{   //Write a program that replaces in a HTML document given as string all the tags
    //"<a href="URL">TEXT</a>" with corresponding markdown notation "[TEXT](URL)".
    //Example:
                //input	
                //<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to 
                //discuss the courses.</p>	
                //output
                //<p>Please visit [URL=http://academy.telerik. com] our site[/URL] to choose a training course. 
                //Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

    class Program
    {
        static void Main()
        {
            string input = @"Please visit <a href=""http://academy.telerik. com"">our site to choose a training course. Also visit <a href=""www.devbg.org"">our forum to discuss the courses.";

            string openingTagStart = @"<a href=""",     openingTagStartReplacement = @"[URL=";
            string closingTag = @"</a>",                closingTagReplacement = @"[/URL]";
            string openingTagEnd = @""">",              openingTagEndReplacement = @"]";

            string text = String.Empty;

            text = input.Replace(openingTagStart, openingTagStartReplacement);
            text = text.Replace(openingTagEnd, openingTagEndReplacement);
            text = text.Replace(closingTag, closingTagReplacement);

            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}
