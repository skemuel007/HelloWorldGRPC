using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    public class Program
    {
        async static Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7002");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(
                new HelloRequest
                {
                    Name = "Hello SWN Client"
                });

            Console.WriteLine($"Greetings: {reply.Message}");
            Console.ReadKey();
        }
    }
}