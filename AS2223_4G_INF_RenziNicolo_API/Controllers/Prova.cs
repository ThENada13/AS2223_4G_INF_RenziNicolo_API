namespace AS2223_4G_INF_RenziNicolo_API
{
    public class Prova
    {
        public int num { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}