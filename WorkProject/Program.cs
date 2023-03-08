using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using Excel = Microsoft.Office.Interop.Excel;
using static methods.Methods;

namespace WorkProject;
class Program
{
    static void Main(string[] args)
    {
        
        
        String line = "2775MBP	Малыш	Диана	59300";
        Print($"{line}\n\n");
        WorkFormater("2775MBP", "Малыш","Диана", "59300");
        
        WorkFormater("2775MBP", "Малыш","Диана", "59300");
        WorkFormater("2776MBP", "Малыш","Диана", "59300");
        WorkFormater("2777MBP", "Малыш","Диана", "59300");
        WorkFormater("2778MBP", "Малыш","Диана", "59300");
        WorkFormater("2779MBP", "Комод 105","Диана", "65300");
        WorkFormater("2780MBP", "Комод 105","Диана", "65300");
        WorkFormater("2781MBP", "Комод 105","Диана", "65300");
        WorkFormater("2782MBP", "Комод 105","Диана", "65300");
        WorkFormater("2783MBP", "Комод 105","Диана", "65300");
        WorkFormater("2784MBP", "Комод 105","Диана", "65300");
        WorkFormater("2785MBP", "комод 65","Диана", "52800");
        WorkFormater("2786MBP", "комод 65","Диана", "52800");
        WorkFormater("2787MBP", "комод 65","Диана", "52800");
        WorkFormater("2788MBP", "комод 65","Диана", "52800");
        WorkFormater("2789MBP", "комод 65","Диана", "52800");
        WorkFormater("2790MBP", "Комод 83Н","Диана", "55500");
        WorkFormater("2791MBP", "Комод 83Н","Диана", "55500");
        WorkFormater("2792MBP", "Комод 83Н","Диана", "55500");
        WorkFormater("2793MBP", "Комод 84 с Нишей","Диана", "55800");
        WorkFormater("2794MBP", "Комод 84 с Нишей","Диана", "55800");
    }
}
