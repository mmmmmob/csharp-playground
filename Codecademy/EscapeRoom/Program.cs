using System;

public class Program
{
  public static void Main(string[] args)
  {
    // * object reference
    FieldAgent agent1 = new FieldAgent();
    agent1.Name = "Agent Smith";
    agent1.SecretCode = 007;
    FieldAgent agent2 = agent1;
    agent2.SecretCode = 999;
    Console.WriteLine(agent1.SecretCode);
    Console.WriteLine(agent2.SecretCode);

    // * comparing object reference
    File file1 = new File();
    file1.FileName = "Confidential.txt";
    file1.FileSize = 1024;
    File file2 = new File();
    file2.FileName = "Confidential.txt";
    file2.FileSize = 1024;
    // comparing object reference performs a 'referential comparison' (check if refer to the same memory location or not)
    bool sameFile = file1 == file2;
    Console.WriteLine(sameFile); // -> False because file1 and file2 are completely different object

    // * array of references
    Server mainServer = new Server();
    Server backupServer = new Server();
    mainServer.Status = "Active";
    backupServer.Status = "Inactive";
    ISystem[] systems = new ISystem[] { mainServer, backupServer };
    foreach (ISystem system in systems)
    {
      system.Operate();
    }
  }
}