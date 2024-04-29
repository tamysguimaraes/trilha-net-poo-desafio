namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; protected set; }
        public int Memoria { get; protected set; }
        public string IMEI { get; protected set; }

        public Smartphone(string numero, string modelo,   string imei,int memoria)
        {
            Numero = string.IsNullOrWhiteSpace(numero)
                ? throw new ArgumentNullException("numero", "O número não pode ser nulo, vazio ou conter apenas espaços em branco.")
                : numero;

            Modelo = string.IsNullOrWhiteSpace(modelo)
                    ? throw new ArgumentNullException("modelo", "O modelo não pode ser nulo, vazio ou conter apenas espaços em branco.")
                    : modelo;

            Memoria = memoria > 0
                ? memoria
                : throw new ArgumentOutOfRangeException("memoria", "A memória deve ser maior que zero.");

            IMEI = string.IsNullOrWhiteSpace(imei)
                ? throw new ArgumentNullException("imei", "O IMEI não pode ser nulo, vazio ou conter apenas espaços em branco.")
                : imei;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}