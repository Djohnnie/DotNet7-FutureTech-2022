using Grpc.Net.Client;

namespace FutureTech2022.GrpcJsonTranscoding
{
    public class ClientDemo
    {
        public async Task<string> GetMessageFromGrpc(string name)
        {
            var channel = GrpcChannel.ForAddress("https://something/");
            
            var client = new Greeter.GreeterClient(channel);
            
            var request = new HelloRequest { Name = name };
            
            var response = await client.SayHelloAsync(request);
            
            return response.Message;
        }
    }
}