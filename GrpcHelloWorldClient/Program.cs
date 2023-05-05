﻿using Grpc.Net.Client;
using GrpcHelloWorldClient.Protos;

namespace GrpcHelloWorldClient
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7001");
            var client = new HelloService.HelloServiceClient(channel);

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