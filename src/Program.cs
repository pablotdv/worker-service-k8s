using WorkerService1;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHealthChecks().AddCheck<CustomHealthCheck>("custom_hc");
        services.AddHostedService<TcpHealthProbeService>();

    })
    .Build();

await host.RunAsync();
