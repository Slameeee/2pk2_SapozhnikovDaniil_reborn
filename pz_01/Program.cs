using System;

namespace pz_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Atom o2 = new Atom("imya",1,2,9);
            Atom o3 = new Atom("familiya", 9, 4, 0);
            o2.GetInfo();
            o3.GetInfo();
        }
    }
}
