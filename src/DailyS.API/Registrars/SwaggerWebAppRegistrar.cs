using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace DailyS.API.Registrars
{
    public class SwaggerWebAppRegistrar : IWebApplicationRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    config.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.ApiVersion.ToString()
                    );
                }
            });
        }
    }
}
