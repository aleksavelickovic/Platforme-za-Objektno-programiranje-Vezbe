using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe3
{
    public class Greeting
    {
        public enum GreetingEnum
        {
            FORMAL,
            INFORMAL
        }

        public String text { get; set; }
        public String title { get; set; }
        
        public Greeting()
        {
            this.text = "";
            this.title = "";
        }

        public Greeting(string text, string title)
        {
            this.text = text;
            this.title = title;
        }

        
    }
}
