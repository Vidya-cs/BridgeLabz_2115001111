using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class Program8{
    static void WriteToPipe(object serverStream){
        using (StreamWriter writer = new StreamWriter((AnonymousPipeServerStream)serverStream)){
            writer.AutoFlush = true;
            writer.WriteLine("Hello");
            writer.WriteLine("Here is Vidya");
            writer.WriteLine("Pipe stream");
        }
    }

    static void ReadFromPipe(object clientStream){
        using (StreamReader reader = new StreamReader((AnonymousPipeClientStream)clientStream)){
            string line;
            while ((line = reader.ReadLine()) != null){
                Console.WriteLine("Received " + line);
            }
        }
    }

    public static void Main(string[] args){
        using (AnonymousPipeServerStream serverStream = new AnonymousPipeServerStream(PipeDirection.Out))
        using (AnonymousPipeClientStream clientStream = new AnonymousPipeClientStream(PipeDirection.In, serverStream.GetClientHandleAsString())){
            Thread writerThread = new Thread(WriteToPipe);
            Thread readerThread = new Thread(ReadFromPipe);
            writerThread.Start(serverStream);
            readerThread.Start(clientStream);

            writerThread.Join();
            readerThread.Join();
        }
    }
}
