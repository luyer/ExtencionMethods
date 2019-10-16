using System;

namespace ExtencionMethods.Extencions
{
    public static class Extencions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },  StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string FullName( this Person persona)
        {       
            return persona.FirstName+' '+persona.MiddleName+' '+persona.LastName;
        }

        public static string Description( this Person persona)
        {
            return "Hola mi nombre es: "+persona.FullName()+
            "; mi cabello es de color: "+persona.HairColor+
            "; mis ojos son de un hermoso color: "+persona.EyeColor;
        }


    }
}



  