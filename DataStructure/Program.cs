internal class Program
{
    private static void Main(string[] args)
    {
        ///Trabalhando com lista (list)
        //Criando uma lista
        List<string> fruits = new List<string>();

        //Adicionando itens na lista
        fruits.Add("Morango");
        fruits.Add("Manga");
        fruits.Add("Lichia");
        fruits.Add("Uva");

        // Impressão da Lista em uma Única Linha
        Console.WriteLine("Minha Lista de Frutas:");
        fruits.ForEach(Console.WriteLine);

        Console.WriteLine(); // Pula linha em branco

        //Imprimir elemento na posição específica
        Console.WriteLine("Fruta na indice 2: " + fruits[2]);

        //Inserindo um elemento na posiç~so específica
        fruits.Insert(1, "Marácuja");

        //Imprimindo a lista novamente
        Console.WriteLine(); //pula linha em branco

        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //alterando um elemento no indice especifico
        fruits.Insert(4, "Pêra");

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Apagar todos os elementos da lista 
        fruits.Clear();

        Console.WriteLine();
    }
}