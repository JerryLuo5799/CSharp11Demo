
using System.Text;

string testText = "FireUG技术社区";

ReadOnlySpan<Byte> u8TestText ="FireUG技术社区"u8;
 
var u16TestText =Encoding.Unicode.GetBytes("FireUG技术社区");

var u8TextOld =Encoding.UTF8.GetBytes("FireUG技术社区");

Console.Write("u8TestText: ");
foreach(var value in u8TestText)
{
    Console.Write(value + " ");
}
Console.WriteLine();
Console.Write("u16TestText:");
foreach(var value in u16TestText)
{
    Console.Write(value + " ");
}
Console.WriteLine();
Console.Write("u8TextOld:  ");
foreach(var value in u8TextOld)
{
    Console.Write(value + " ");
}