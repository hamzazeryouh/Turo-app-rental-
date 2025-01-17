using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Turo.Application.Interfaces;
using Turo.Application.Maping;
using Turo.Domain.Entities;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository;
using Turo.Infrastructure.Repository.Base;
using Turo.Infrastructure.Repository.Cars;
using Turo.Infrastructure.Services;
using Turo.Infrastructure.Services.CarService;
using Turo.Infrastructure.UnitOfWork;
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateSlimBuilder(args);



builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IBaseService<,,>), typeof(BaseService<,,,>));
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
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
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.Run();


