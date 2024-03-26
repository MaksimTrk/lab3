using lab3._2;
using System.IO;
using System.Text.Json;
using System.Xml;

Main();

void Main()
{
    Console.WriteLine("Введiть дiйсну частину першого числа:");
    double real1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введiть уявну частину першого числа:");
    double imaginary1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введiть дiйсну частину другого числа:");
    double real2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введiть уявну частину другого числа:");
    double imaginary2 = double.Parse(Console.ReadLine());

    ComplexNumber num1 = new ComplexNumber(real1, imaginary1);
    ComplexNumber num2 = new ComplexNumber(real2, imaginary2);

    ComplexNumber sum = num1.Add(num2);
    ComplexNumber difference = num1.Subtract(num2);
    ComplexNumber product = num1.Multiply(num2);

    Console.WriteLine($"Сума: {sum}");
    Console.WriteLine($"Рiзниця: {difference}");
    Console.WriteLine($"Добуток: {product}");
    JsonSave(sum, difference, product);
    LoadFromJson();
}

void JsonSave(ComplexNumber sum, ComplexNumber difference, ComplexNumber product)
{
    string jsonSum = JsonSerializer.Serialize(sum);
    string jsonDifference = JsonSerializer.Serialize(difference);
    string jsonProduct = JsonSerializer.Serialize(product);
    string paths = "D:\\lab3(2)\\resultsum.json";
    string pathd = "D:\\lab3(2)\\resultdif.json";
    string pathp = "D:\\lab3(2)\\resultproduct.json";


    File.WriteAllText(paths, jsonSum);
    File.WriteAllText(pathd, jsonDifference);
    File.WriteAllText(pathp, jsonProduct);

    Console.WriteLine("Результат був збережений у файл.");
}
void LoadFromJson()
{
    string filePathS = "D:\\lab3(2)\\resultsum.json";
    string filePathD = "D:\\lab3(2)\\resultdif.json";
    string filePathP = "D:\\lab3(2)\\resultproduct.json";
    string jsonDataS = File.ReadAllText(filePathS);
    string jsonDataD = File.ReadAllText(filePathD);
    string jsonDataP = File.ReadAllText(filePathP);
    ComplexNumber results = JsonSerializer.Deserialize<ComplexNumber>(jsonDataS);
    ComplexNumber resultd = JsonSerializer.Deserialize<ComplexNumber>(jsonDataD);
    ComplexNumber resultp = JsonSerializer.Deserialize<ComplexNumber>(jsonDataP);

    Console.WriteLine($"Данi, зчитанi з JSON: {results}, {resultd}, {resultp}");
}
