// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Directory.CreateDirectory("temp");
Directory.CreateDirectory("temp/trying");//creating a directory

Directory.Delete("temp/trying");//deleting a directory
Directory.Delete("temp");//deleting a directory

if(Directory.Exists("temp"))//checking if a directory exists
{
    Console.WriteLine("Directory exists");
}
else
{
    Console.WriteLine("Directory does not exist");
}

string path = "/Users/hande/RiderProjects/BTK Academy/Csharp Directory/temp";
Directory.CreateDirectory(path);//creating a directory
//We create a directory with the path we specified and we do this wherever we want. Such as desktop, documents, etc.

string[] directories = Directory.GetDirectories(path);//getting all directories in the path
foreach (var directory in directories)
{
    Console.WriteLine(directory);
}

string[] files = Directory.GetFiles(path);//getting all files in the path
foreach (var file in files)
{
    Console.WriteLine(file);
}

/*
Directory.Move(path, "/Users/hande/RiderProjects/BTK Academy/Csharp Directory/temp2");//moving a directory
//We move the directory we specified to the path we specified.
*/

string path2 = Directory.GetCurrentDirectory();//getting the current directory
Console.WriteLine(path2);

string RootPath = Directory.GetCurrentDirectory();
/*
string[] directories2 = Directory.GetDirectories(RootPath, "*", SearchOption.TopDirectoryOnly);
foreach (var directory in directories2)
{
    Console.WriteLine(directory);
}
*/
string [] files2 = Directory.GetFiles(RootPath, "*.txt", SearchOption.AllDirectories);//getting all files with the extension .txt
foreach (var file in files2)
{
    Console.WriteLine(file);
    Console.WriteLine(Path.GetFileName(file));//getting the file name
    Console.WriteLine(Path.GetExtension(file));//getting the file extension
    Console.WriteLine(Path.GetFullPath(file));//getting the full path of the file
    Console.WriteLine(Path.GetDirectoryName(file));//getting the directory of the file
    
    var fileInfo = new FileInfo(file);
    Console.WriteLine(fileInfo.Name);
    Console.WriteLine(fileInfo.Extension);
    Console.WriteLine(fileInfo.Length);
    Console.WriteLine(fileInfo.CreationTime);
    Console.WriteLine(fileInfo.LastAccessTime);
    Console.WriteLine($"{Path.GetFileName(file)} - {fileInfo.Length} bytes");
}








