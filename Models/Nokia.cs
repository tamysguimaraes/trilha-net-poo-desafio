namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei,int memoria) : base(numero, modelo,imei, memoria)
        {
        }

        
        //     {
        //         if (MemoriaInterna < 3 || Aplicativos.Any(a => a.ToUpper() == nomeApp.ToUpper()))
        //         {
        //             Console.WriteLine($@"Seu Smartphone {Marca} - {Modelo} não possui memória suficiente
        //         ou esse aplicativo já está instalado no sistema.");
        //             return false;
        //         }

        //         Aplicativos.Add(nomeApp.ToUpper());
        //         MemoriaInterna -= 2;

        //         
        //         return true;
        //     }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($" O aplicativo {nomeApp} foi instalado com sucesso no Nokia - {Modelo}");
        }
    }
}