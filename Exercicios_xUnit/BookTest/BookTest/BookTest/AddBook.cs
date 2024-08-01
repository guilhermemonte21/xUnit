using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTest
{
    
    public class AddBook
    {

        public static List<Object> Adicionar(string x, string y, string z)
        {

            var Lista = new List<Object>();

            var newBook = new {
                nome = x, Gender = y, Pages = z };
                
            
            Lista.Add(newBook);
            
            return Lista;
            

        }

    }
}
