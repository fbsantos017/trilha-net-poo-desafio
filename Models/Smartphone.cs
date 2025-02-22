namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }

        protected string Imei { get; set; }

        public int Memoria { get; set; }

        public Smartphone()
        {

        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;

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