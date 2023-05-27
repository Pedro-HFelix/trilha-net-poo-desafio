namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        override public void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}...");
              for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(".......");
            }
            System.Console.WriteLine($"{nomeApp} Instalado com sucesso!");
        }
        }
    }
