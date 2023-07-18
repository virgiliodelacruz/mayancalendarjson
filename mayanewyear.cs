namespace HelloWorld

{
    class mayanewyear
    {
        public void create()
        {
            int initialyear=1920;
            int initialmonth=4;
            int initialday = 25;
        DateTime from = new DateTime(initialyear, initialmonth, initialday);
            DateTime thru = new DateTime(2080, 3, 31);
            string[] yearbearer={"Caban","Ik","Manik","Eb"};
             string[] directions={"East","North","West","South"};
        
            int piv = 0;
    
            int dia = 13;
            
            string descanio ="";
            string yb = "";
             List<registro> listaregistros = new List<registro>();
             var day = from.Date; 
          while (day.Date <= thru.Date)
            {
                for( var x=1;x<=4;x++)
                {
                    descanio = dia+"-"+directions[piv];
                    yb = yearbearer[piv];
                     Console.WriteLine(day.ToShortDateString()+","+ descanio+","+yb);
                      if(piv == 3)
                        piv=0;
                      else
                        piv++;
                    if(dia == 13)
                      dia=1;
                    else
                      dia++;
                    day = day.AddYears(1);
                }
                day = day.AddDays(-1);
            
               
            }
            //var fileName = "mayancalendar.json";
            //JsonFileUtils.PrettyWrite(listaregistros, fileName);
        }
    }

    
    
} 