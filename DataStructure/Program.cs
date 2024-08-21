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
        Console.WriteLine("Lista de Frutas:");
        fruits.ForEach(Console.WriteLine);

        Console.WriteLine(); // Pula linha em branco

        //Imprimir elemento na posição específica
        Console.WriteLine("Fruta na indice 2: " + fruits[2]);

        //Inserindo um elemento na posiç~so específica
        fruits.Insert(1, "Marácuja");

        //Imprimindo a lista novamente
        Console.WriteLine(); //pula linha em branco

        Console.WriteLine("Lista de Frutas:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //alterando um elemento no indice especifico
        fruits.Insert(4, "Pêra");

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("Lista de Frutas:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Apagar todos os elementos da lista 
        fruits.Clear();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        // Trabalhando com Dicionário (Dictionary)
        Console.WriteLine("Dicionário de Carros:");

        // Criando um Dicionário de Dados
        Dictionary<int, string> cars = new Dictionary<int, string>();
        // Adicionar Dados a um Dicionário
        cars.Add(5, "Corsa");
        cars.Add(10, "Fusca");
        cars.Add(2, "Ford Ka");

        // Imprimir um Dicionário de Dados
        foreach (var car in cars)
        {

            Console.WriteLine($"{car.Key} - {car.Value}");

        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        // Trabalhando com Fila (Queue)
        Console.WriteLine("Fila de Carros:");

        // Criar uma Fila
        Queue<string> bank = new Queue<string>();

        // Adicionar Elementos na Fila
        bank.Enqueue("André");
        bank.Enqueue("Maria");
        bank.Enqueue("João");
        bank.Enqueue("Bia");

        foreach (var person in bank)
        {
            Console.WriteLine(person);
        }

        // Retirar Primeiro Elemento da Fila
        bank.Dequeue();
        Console.WriteLine();

        foreach (var person in bank)
        {

            Console.WriteLine(person);

        }

        // Verificar se Existe um Elemento na Fila
        bool find = bank.Contains("Bia");
        if (find == true)
        {
            Console.WriteLine("A Pessoa está na Fila");
        }
        else
        {
            Console.WriteLine("A Pessoa não está na Fila");
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        // Trabalhando com Pilha (Stack)
        Console.WriteLine("Pilha de Livros:");

        // Criando uma Pilha 
        Stack<string> books = new Stack<string>();

        // Adicionar Elementos a uma Pilha
        books.Push("Chapéuzinho Vermelho");
        books.Push("Branca de Neve");
        books.Push("A Princesa e o Sapo");

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine();

        // Remove o Primeiro Elemento da Pilha
        books.Pop();
        foreach (var book in books)
        { Console.WriteLine(book); }

        Console.WriteLine();

    }
}