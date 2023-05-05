using Grpc.Core;
using GrpcHelloWorldServer.Protos;

namespace GrpcHelloWorldServer.Services
{
    public class HelloWorldService : HelloService.HelloServiceBase
    {
        private readonly ILogger<HelloWorldService> _logger;

        public HelloWorldService(ILogger<HelloWorldService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public override Task<HelloResponse> SayHello(HelloRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Request received...");
            string resultMessage = $"Hello {request.Name}";
            var response = new HelloResponse()
            {
                Message = resultMessage,
            };

            _logger.LogInformation($"Hello response: {response}");

            return Task.FromResult(response);
        }
    }
}
