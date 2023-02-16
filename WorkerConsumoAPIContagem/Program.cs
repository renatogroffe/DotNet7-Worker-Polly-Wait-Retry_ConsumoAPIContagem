using WorkerConsumoAPIContagem;
using WorkerConsumoAPIContagem.Resilience;
using Polly;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddSingleton<AsyncPolicy>(
            WaitAndRetryExtensions.CreateWaitAndRetryPolicy(new []
            {
                TimeSpan.FromSeconds(5)
            }));
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();