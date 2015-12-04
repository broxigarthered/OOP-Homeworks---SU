using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher.Namespace
{
    class ElementBuilder
    {
        public string name;
        public static string result;
        public StringBuilder attributes;
        public StringBuilder contents;

        public StringBuilder Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        public  StringBuilder Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }
        

        public ElementBuilder(string elementName)
        {
            this.Name = elementName;
            this.Contents = new StringBuilder();
            this.Attributes = new StringBuilder();
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public void AddAtribute(string attribute, string value)
        {
            attributes.AppendFormat("{0} = \"{1}\" ",attribute,value);
        }

        public void AddContent(string c)
        {
            contents.Append(c);

        }


        public static string operator *(ElementBuilder x, int a)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                sb.Append(x);
                sb.Append(Environment.NewLine);

            }
            string res = sb.ToString().Substring(0, sb.Length - 1);
            return res;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("<{0} ", this.Name);
            result.Append(Attributes);
            result.Append(Contents);
            result.AppendFormat("</{0}>", this.Name);
            return result.ToString();
        }
    }
}
