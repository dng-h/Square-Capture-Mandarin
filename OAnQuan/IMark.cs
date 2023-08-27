using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OAnQuan
{
    internal interface IMark
    {
        int Mark { get; set; }
        int Borrow { get; set; }
    }
    public class MarkOfPerson : IMark
    {
        public int Mark { get; set; }
        public int Borrow { get; set; }
    }
    public class MarkOfComputer : IMark
    {
        public int Mark { get; set; }
        public int Borrow { get; set; }
    }
}
