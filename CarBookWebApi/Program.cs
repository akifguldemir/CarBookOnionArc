using CarBookApplication.Features.CQRS.Handlers.AboutHandlers;
using CarBookApplication.Features.CQRS.Handlers.BannerHandlers;
using CarBookApplication.Features.CQRS.Handlers.BrandHandlers;
using CarBookApplication.Features.CQRS.Handlers.CarHandlers;
using CarBookApplication.Features.CQRS.Handlers.CategoryHandlers;
using CarBookApplication.Features.CQRS.Handlers.ContactHandlers;
using CarBookApplication.Features.RepositoryPattern.CommentRepositories;
using CarBookApplication.Interfaces;
using CarBookApplication.Interfaces.BlogInterfaces;
using CarBookApplication.Interfaces.CarFeatureInterfaces;
using CarBookApplication.Interfaces.CarInterfaces;
using CarBookApplication.Interfaces.CarPricingInterfaces;
using CarBookApplication.Interfaces.RentACarInterfaces;
using CarBookApplication.Interfaces.StatisticsInterfaces;
using CarBookApplication.Services;
using CarBookPersistence.Context;
using CarBookPersistence.Repositories;
using CarBookPersistence.Repositories.BlogRepositories;
using CarBookPersistence.Repositories.CarFeatureRepositories;
using CarBookPersistence.Repositories.CarPricingRepositories;
using CarBookPersistence.Repositories.CarRespositories;
using CarBookPersistence.Repositories.CommentRepositories;
using CarBookPersistence.Repositories.RentACarRepositories;
using CarBookPersistence.Repositories.StatisticsRepositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = "https://localhost",
        ValidIssuer = "https://localhost",
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("carbookcarbook01")),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});

// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));

builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsBrandQueryHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
