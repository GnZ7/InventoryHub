var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        var frontEndUrls = builder.Configuration.GetSection("FrontEndUrl")
                                                .Get<string[]>() ??
                                                throw new InvalidOperationException("FrontEndUrl configuration is missing.");
        policy.WithOrigins(frontEndUrls)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

app.UseHttpsRedirection();

app.Run();