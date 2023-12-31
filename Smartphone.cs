namespace poo_desafio_cel
{
    abstract class Smartphone
    {
        string numero;
        string modelo;
        string imei;
        int memoria;

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public string Numero { get => numero; set => numero = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Imei { get => imei; set => imei = value; }
        public int Memoria { get => memoria; set => memoria = value; }



        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string AppName);









    }
}
