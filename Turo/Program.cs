using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Globalization;
using System.Reflection;
using Turo.Application.Interfaces;
using Turo.Application.Maping;
using Turo.Application.Queries.Car.Turo.Application.Handlers.Cars;
using Turo.Application.Services;
using Turo.Application.Services.CarService;
using Turo.Application.Validators;
using Turo.Helpers;
using Turo.Infrastructure.Helpers;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository;
using Turo.Infrastructure.Repository.Base;
using Turo.Infrastructure.Repository.Cars;
using Turo.Infrastructure.UnitOfWork;
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
//System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
//System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-US");
var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IBaseService<,,,>), typeof(BaseService<,,,>));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<ITranslationService, TranslationService>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<CreateCarDtoValidator>();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("*")
            .AllowAnyMethod()
            .AllowAnyHeader()
            ;
        });
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
    typeof(GetAllCarsQueryHandler).Assembly
));



builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Turo API",
        Version = "v1",
        Description = "API documentation for Turo project",
        Contact = new OpenApiContact
        {
            Name = "Hamza Zeryouh",
            Url = new Uri("https://www.linkedin.com/in/hamza-zeryouh")
        }
    });



    // Enable XML Comments (Optional)
    var xmlFilename = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' followed by a valid token."
    });

    options.AddSecurityDefinition("Accept-Language", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Accept-Language",
        Type = SecuritySchemeType.ApiKey,
        Description = "Language for translations (e.g., 'en', 'fr')"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Turo API V1");
        options.RoutePrefix = string.Empty; // Set Swagger UI as the homepage
    });
}
app.MapControllers();
app.UseAuthorization();
app.Run();


