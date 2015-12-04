using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher.Namespace
{
    class main
    {
         static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id","page");
            div.AddAtribute("class","big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div*2);

            string url = HTMLDispatcher.CreateURL("www.gmail.com", "Gmail", "Link to gmail.com");
            string image = HTMLDispatcher.CreateImage("c://image.jpg", "some image", "Image");
            string input = HTMLDispatcher.CreateInput("text", "username", "user");
         
            Console.WriteLine(url);
            Console.WriteLine(image);
            Console.WriteLine(input);
        }
    }
}
