using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TreeStructure
{
    [Serializable]
    public class Node
    {
        public Node? Parent { get; set; } // No parent? Must be a root...
        public List<Node> ChildNodes { get; set; } = new List<Node>(); // No child nodes? Must be a leaf..


        public string Token { get; set; } = String.Empty;
        public int StartsAt = 0;
        public int EndsAt = 0;
    }
}
