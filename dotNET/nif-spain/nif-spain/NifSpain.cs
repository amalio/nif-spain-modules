using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nif_spain
{
    public class NifSpain
    {
        

        public Char GetLetter(int numers)
        {
            String correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
            return correspondencia[numers % 23];
        }

        public Char GetLetter(string numbersString)
        {
            var numbers = 0;
            int.TryParse(numbersString, out numbers);
            if (numbers == 0)
                throw new ArgumentException();
            return GetLetter(numbers);
        }

        public bool Check(String nifString)
        {
            if (nifString.Length != 9)
                return false;
            else
            {
                var numbers = 0;
                int.TryParse(nifString.Substring(0, 8), out numbers);
                if (numbers == 0)
                    return false;
                else
                {
                    var validLetter = GetLetter(numbers);
                    return validLetter == nifString[8];
                }
            }
        }
    }
}
