﻿namespace Bit.Websites.Sales.Api;

public class AppSettings
{
    public HealthCheckSettings HealthCheckSettings { get; set; } = default!;

    public TelegramBotSettings TelegramBotSettings { get; set; } = default!;

    public string UserProfileImagesDir { get; set; } = default!;

    public string WebServerAddress { get; set; } = default!;
}

public class HealthCheckSettings
{
    public bool EnableHealthChecks { get; set; }
}

public class TelegramBotSettings
{
    public string Token { get; set; }
    public string[] ChatIds { get; set; }
}
