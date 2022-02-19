using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Star
{
    [Serializable]
    public class MovieStar
    {
        public DateTime dateOfBirth { get; set; }
        
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Sex { get; set; }

        public string Nationality { get; set; }
    }
}
