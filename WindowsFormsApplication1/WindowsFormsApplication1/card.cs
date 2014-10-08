using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class card
    {
        //craete the variables for a card
        public string name; //{ get; set; }
        public int smite { get; set; }
        public int defence { get; set; }
        public int followers { get; set; }
        public int cruelty { get; set; }
        public int forgiveness { get; set; }
        // compares two values and out puts a result
        public int Compare(int other, string type)
        {
            switch (type)
            {
                case "smite":
                    if (this.smite > other)
                    {
                        return (0);
                    }
                    else if (this.smite < other)
                    {
                        return (1);
                    }
                    else
                    {
                        return (2);
                    }
                case "defence":
                    if (this.defence > other)
                    {
                        return (0);
                    }
                    else if (this.defence < other)
                    {
                        return (1);
                    }
                    else
                    {
                        return (2);
                    }
                case "followers":
                    if (this.followers > other)
                    {
                        return (0);
                    }
                    else if (this.followers < other)
                    {
                        return (1);
                    }
                    else
                    {
                        return (2);
                    }
                case "cruelty":
                    if (this.cruelty > other)
                    {
                        return (0);
                    }
                    else if (this.cruelty < other)
                    {
                        return (1);
                    }
                    else
                    {
                        return (2);
                    }
                case "forgiveness":
                    if (this.forgiveness > other)
                    {
                        return (0);
                    }
                    else if (this.forgiveness < other)
                    {
                        return (1);
                    }
                    else
                    {
                        return (2);
                    }
                default:
                    return (0);
            }
        }
    }
}
