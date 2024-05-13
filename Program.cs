using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_DataBase_FirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var j = new shamEntities1();
            Table s = new Table() { 
            
            addr="Pareal",
                id = 11, 
            };
            j.Tables.Add(s);
            j.SaveChanges();
        }
    }
}
