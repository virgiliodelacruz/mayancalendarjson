//https://www.hackertouch.com/get-all-dates-between-two-dates-in-c-sharp.html
//https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0
//https://code-maze.com/csharp-write-json-into-a-file/

namespace HelloWorld

{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime from = new DateTime(1919, 12, 31);
            DateTime thru = new DateTime(2090, 12, 31);
            string[] signs={"Imix", "Ik", "Akbal", "Kan","Chicchan","Cimi",
            "Manik","Lamat","Muluc","Oc","Chuen","Eb","Ben","Ix",
            "Men","Cib","Caban","Etz'nab","Cauac","Ahuau"};
            int lord = 7;
            int piv = 0;
            int dia = 1;
            string trecena;
             trecena = dia+"-"+signs[piv];
             List<registro> listaregistros = new List<registro>();
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            {
               int year = day.Year;
               int month= day.Month;
               int internaldia = day.Day;
               int diasemana = (int)day.DayOfWeek;
               string daysign= dia+"-"+signs[piv];
               int internallord = lord;
               string internaltrecena = trecena;
            registro r = new registro();
            r.year = year;
            r.month = month;
            r.day = internaldia;
            r.daysign = daysign;
            r.lord = internallord;
            r.trecena = trecena;
            r.dayofweek = diasemana;
            listaregistros.Add(r);
            Console.WriteLine(day.ToString("dddd") +" "+ day.ToShortDateString()+ ","+dia+"-"+signs[piv]+",Lord:"+lord+",Trecena:"+trecena);
               if(piv == 19)
                    piv=0;
               else
                 piv++;
               if(lord == 9)
                 lord=1;
               else
                 lord++;
               if(dia == 13)
               {
                 dia=1;
                 trecena = dia+"-"+signs[piv];
               }
               else
                 dia++;
            }
            var fileName = "mayancalendar.json";
            JsonFileUtils.PrettyWrite(listaregistros, fileName);
        }
    }
}