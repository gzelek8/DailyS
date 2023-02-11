using DailyS.API.Options;

namespace DailyS.API.Registrars;

public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();

        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
    }
}
