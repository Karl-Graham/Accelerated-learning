using System;

namespace Module__6
{
    class Adress
    {
        
        

        public string zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                if (value.Length == 6)
                {
                    char[] numbers =value.ToCharArray();

                    if (numbers[0] == "0" )
                    {

                    }
                }

                
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            var t = new Adress();
            t.zipcode = "12345";

            

            



        }
    }
}
