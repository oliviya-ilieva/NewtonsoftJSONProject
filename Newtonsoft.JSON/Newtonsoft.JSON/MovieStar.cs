using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft.JSON
{
    [Serializable]
    public class MovieStar
    {


        public DateTime dateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }

       
    }
}
