
using static methods.Methods;
using System.Text;
namespace NewWorkTest;
class Program
{
    static async Task Main(string[] args)
    {
//         string path = @"C:\app\note.txt";   // путь к файлу
//  
//         string text = "Hello METANIT.COM"; // строка для записи
//  
// // запись в файл
//         using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//         {
//             // преобразуем строку в байты
//             byte[] buffer = Encoding.Default.GetBytes(text);
//             // запись массива байтов в файл
//             await fstream.WriteAsync(buffer, 0, buffer.Length);
//             Console.WriteLine("Текст записан в файл");
//         }
//  
// // чтение из файла
//         using (FileStream fstream = File.OpenRead(path))
//         {
//             // выделяем массив для считывания данных из файла
//             byte[] buffer = new byte[fstream.Length];
//             // считываем данные
//             await fstream.ReadAsync(buffer, 0, buffer.Length);
//             // декодируем байты в строку
//             string textFromFile = Encoding.Default.GetString(buffer);
//             Console.WriteLine($"Текст из файла: {textFromFile}");
//         }
        
        String line = "2775MBP	Малыш	Диана	59300";
        Print($"{line}\n\n");
        WorkFormater("2775MBP", "Малыш","Диана", "59300");
        
        WorkFormater("2775MBP", "Малыш","Диана", "59300");
        WorkFormater("2776MBP", "Малыш","Диана", "59300");
        WorkFormater("2777MBP", "Малыш","Диана", "59300");
        WorkFormater("2778MBP", "Малыш","Диана", "59300");
        
        }
    }
