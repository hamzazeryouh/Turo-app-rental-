using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Turo.Application.Maping;
using Turo.Domain.Entities;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository;
using Turo.Infrastructure.Repository.Base;
using Turo.Infrastructure.Repository.Cars;
using Turo.Infrastructure.UnitOfWork;

var builder = WebApplication.CreateSlimBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

app.Run();


