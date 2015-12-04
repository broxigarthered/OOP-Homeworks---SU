using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher.Namespace
{
    class HTMLDispatcher
    {
        public static string CreateImage(string source, string alt, string title) 
        {
            ElementBuilder image = new ElementBuilder("img");

            image.AddAtribute("src",source);
            image.AddAtribute("alt",alt);
            image.AddAtribute("title",title);

            return image.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder urlElement = new ElementBuilder("a");

            urlElement.AddAtribute("href", url);
            urlElement.AddAtribute("title", title);
            urlElement.AddContent(text);

            return urlElement.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");

            input.AddAtribute("type", type);
            input.AddAtribute("name", name);
            input.AddAtribute("value", value);

            return input.ToString();
        }
    }
}
