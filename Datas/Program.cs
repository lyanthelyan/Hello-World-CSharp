namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // var data =  new DateTime(2024, 3, 18, 14, 43, 50);
        // var data =  DateTime.Now;
        // Console.WriteLine(data);
        // Console.WriteLine(data.DayOfWeek);
        // if (data.DayOfWeek == DayOfWeek.Monday)Console.WriteLine("Segunda");

        // * FORMATANDO DATAS

        // var data = DateTime.Now;
        
        //? d = Dia; M = Mes; y = Ano; h = Hora; m = Minuto; s = Segundo
        
        // var formato = ($"{data:dd/MM/yy hh:mm:ss}");
        // Console.WriteLine(formato);
        
        //* ADICIONANDO VALORES

        // var data = DateTime.Now;
        // Console.WriteLine(data.AddDays(-5)); //! 13/03/2024 10:19:27
        // Console.WriteLine(data.AddMonths(1));//! 18/04/2024 10:19:27
        // Console.WriteLine(data.AddYears(1)); //! 18/03/2025 10:19:27

        //* COMPARANDO DATAS
        // var newData = new DateTime(2024, 3, 18, 14, 43, 50);
        // var data = DateTime.Now;
        // if (newData == data)Console.WriteLine("É Igual");else Console.WriteLine("Não é igual");


        //* CULTURE INFO

            //!Informações sobre os países
            //! Precisa colocar o System.Globalization no começo do código
        // var br = new System.Globalization.CultureInfo("pt-BR");  
        // var pt = new System.Globalization.CultureInfo("pt-PT");
        // var en = new System.Globalization.CultureInfo("en-US");
        // var de = new System.Globalization.CultureInfo("de-DE");
        
        // Console.WriteLine(DateTime.Now.ToString(en)); //! To String é o metodo que faz o $"{}"

        //* TIME ZONES

        // var utcTime = DateTime.UtcNow; //! Data Global
        // Console.WriteLine(utcTime);
        // Console.WriteLine(utcTime.ToLocalTime());
        
        // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        // Console.WriteLine(timezoneAustralia);
        
        // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezoneAustralia);
        // Console.WriteLine(horaAustralia);

        //* TIME SPAN

        // Console.Clear();
        // var timeSpan = new TimeSpan();
        // Console.WriteLine(timeSpan);

        // var timeSpanNanosegundos = new TimeSpan(1);
        // Console.WriteLine(timeSpanNanosegundos);

        // var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
        // Console.WriteLine(timeSpanHoraMinutoSegundo);

        // var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
        // Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

        // var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
        // Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

        // Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
        // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        //* Métodos

        Console.Clear();

        Console.WriteLine(DateTime.DaysInMonth(2020,2)); //! Quantos tidas tem no mês 2 de 2020

        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

    }

    static bool IsWeekend(DayOfWeek today){
        return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;  //! Função para saber se é final de semana
    }
}
