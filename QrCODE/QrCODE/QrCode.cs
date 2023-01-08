using System;
using System.Collections.Generic;

namespace QrCODE
{
    public class QrCode
    {
        public QrCode()
        {
            char[] StringToChar(string mot)
            {

                char[] lettre = mot.ToCharArray(0, mot.Length );
                Console.WriteLine( lettre );

            }
        }
    }
}
