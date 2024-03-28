namespace Aviao
{
     class Program
    {
        static void Main(string[] args)
        {
            Controle Aviao = new Controle();

            Aviao.Compania = "Decolar";
            Aviao.Modelo = "Boing2411";
            Aviao.Acelerar(40);
            Aviao.Cima(19000);

            Console.WriteLine($"Senhores passageiros, o avião está a { Aviao.Altura}pés, numa velocidade de {Aviao.Velocidade}kmh. Muito obgirado por nos escolher! Você está voando com {Aviao.Compania}, no modelo {Aviao.Modelo}. Uma boa viagem a todos");
        }
    }
}
