// See https://aka.ms/new-console-template for more information

using gRPC.GrpcService;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7016/");
var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(new HelloRequest { Name = "Rodrigo" });

Console.WriteLine(response.Message);
Console.ReadLine();
