

public class Example1
{
  static Queue<string> fileQueue = new Queue<string>();
  static object queueLock = new object();
  static AutoResetEvent fileProcessed = new AutoResetEvent(false);
  static ManualResetEvent startProcessing = new ManualResetEvent(false);

  static int workerCount = 2;
  static int totalFiles = 11;
  static int filesCompleted = 0;

  public static void Run()
  {
    // Load files into queue
    for (int i = 1; i <= totalFiles; i++)
      fileQueue.Enqueue($"File-{i}");

    // Start worker threads
    for (int i = 0; i < workerCount; i++)
    {
      Thread t = new Thread(ProcessFiles);
      t.Name = $"[W-{i + 1}]";
      t.Start();
    }

    Console.WriteLine("[Main] Press a key to start processing...");
    Console.Read();
    startProcessing.Set(); // Signal workers to start processing

    while (true)
    {
      fileProcessed.WaitOne(); // Wait for a file to be processed
      int completed;
      lock (queueLock)
      {
        completed = filesCompleted;
      }

      Console.WriteLine($"[Main] File processed. Total completed: {completed}");

      if (completed >= totalFiles)
        break;
    }

    Console.WriteLine("[Main] All files processed!");
  }

  static void ProcessFiles()
  {
    startProcessing.WaitOne(); // Wait for the signal to start processing

    while (true)
    {
      string? file = null;
      lock (queueLock)
      {
        if (fileQueue.Count > 0)
          file = fileQueue.Dequeue();
      }

      if (file == null)
        break;

      Console.WriteLine($"{Thread.CurrentThread.Name} Processing {file}...");
      Thread.Sleep(new Random().Next(500, 1500)); // Simulate processing

      lock (queueLock)
      {
        filesCompleted++;
      }

      Console.WriteLine($"{Thread.CurrentThread.Name} Done with {file}");
      fileProcessed.Set(); // Signal that a file has been processed
    }

    Console.WriteLine($"{Thread.CurrentThread.Name} No more files. Exiting.");
  }
}
