using CarBookProject.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBookProject.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBookProject.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBookProject.Application.Features.CQRS.Handlers.CarHandlers;
using CarBookProject.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBookProject.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.BlogInterfaces;
using CarBookProject.Application.Interfaces.CarFeatureInterfaces;
using CarBookProject.Application.Interfaces.CarInterfaces;
using CarBookProject.Application.Interfaces.CategoryInterfaces;
using CarBookProject.Application.Interfaces.CommentInterfaces;
using CarBookProject.Application.Interfaces.ContactInterfaces;
using CarBookProject.Application.Interfaces.ICarPricingInterfaces;
using CarBookProject.Application.Interfaces.RentACarInterfaces;
using CarBookProject.Application.Interfaces.ReservationInterfaces;
using CarBookProject.Application.Interfaces.ReviewInterfaces;
using CarBookProject.Application.Interfaces.StatisticInterfaces;
using CarBookProject.Application.Interfaces.TagBlogInterfaces;
using CarBookProject.Application.Services;
using CarBookProject.Application.Tools;
using CarBookProject.Persistence.Context;
using CarBookProject.Persistence.Repositories;
using CarBookProject.Persistence.Repositories.BlogRepositories;
using CarBookProject.Persistence.Repositories.CarFeatureRepositories;
using CarBookProject.Persistence.Repositories.CarPricingRepositories;
using CarBookProject.Persistence.Repositories.CarRepositories;
using CarBookProject.Persistence.Repositories.CategoryRepositories;
using CarBookProject.Persistence.Repositories.CommentRepositories;
using CarBookProject.Persistence.Repositories.ContactRepositories;
using CarBookProject.Persistence.Repositories.RentACarRepositories;
using CarBookProject.Persistence.Repositories.ReservationRepositories;
using CarBookProject.Persistence.Repositories.ReviewRepositories;
using CarBookProject.Persistence.Repositories.StatisticRepositories;
using CarBookProject.Persistence.Repositories.TagBlogRepositories;
using CarBookProject.WebApi.Hubs;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//SignalR CORS Konfigürasyonu
builder.Services.AddCors(opt =>
{
	opt.AddPolicy("CorsPolicy", builder =>
	{
		builder.AllowAnyHeader()
		.AllowAnyMethod()
		.SetIsOriginAllowed((host) => true)
		.AllowCredentials();
	});
});
builder.Services.AddSignalR();


// Add services to the container.

//JWT Bearer Konfigürasyonu
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
	opt.RequireHttpsMetadata = false;
	opt.TokenValidationParameters = new TokenValidationParameters
	{
		ValidAudience = JwtTokenDefaults.ValidAudience,
		ValidIssuer = JwtTokenDefaults.ValidIssuer,
		ClockSkew = TimeSpan.Zero,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
	};
});

#region InterfacesClass

builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); //** Typeof ile Repository sýnýfýný  tanýmlýyoruz.
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
builder.Services.AddScoped(typeof(ITagBlogRepository), typeof(TagBlogRepository));
builder.Services.AddScoped(typeof(IContactRepository), typeof(ContactRepository));
builder.Services.AddScoped(typeof(IStatisticRepository), typeof(StatisticRepository));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IReservationRepository), typeof(ReservationRepository));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));
#endregion

#region CQRSHandlers
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<DeleteAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<DeleteBannerCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<DeleteCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetCarLast5WithBrandQueryHandler>();
builder.Services.AddScoped<GetCarWithPricingQueryHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<DeleteBrandCommandHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<DeleteCategoryCommandHandler>();
builder.Services.AddScoped<GetCategoryWithBlogCountQueryHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<DeleteContactCommandHandler>();


builder.Services.AddScoped<GetBlogQueryHandler>();
builder.Services.AddScoped<GetBlogByIdQueryHandler>();
builder.Services.AddScoped<CreateBlogCommandHandler>();
builder.Services.AddScoped<UpdateBlogCommandHandler>();
builder.Services.AddScoped<DeleteBlogCommandHandler>();
builder.Services.AddScoped<GetBlogWithAllInfoByIdQueryHandler>();
builder.Services.AddScoped<GetBlogLast3WithAllInfoQueryHandler>();
builder.Services.AddScoped<GetBlogWithAllInfoQueryHandler>();
#endregion 

builder.Services.AddApplicationService(builder.Configuration);//ServiceRegistration sýnýfýnýn içindeki metodu çaðýrýyoruz.


builder.Services.AddControllers().AddFluentValidation(x =>
{
	x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});

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
app.UseCors("CorsPolicy"); //Cors Konfigürasyonu
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<CarHub>("/carhub"); //SignalR tarafýna istek yapmayý saðlayan yapý.
app.Run();
