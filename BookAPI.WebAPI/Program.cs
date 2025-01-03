using BookAPI.BusinessLayer.Abstract;
using BookAPI.BusinessLayer.Concrete;
using BookAPI.DataAccessLayer.Abstract;
using BookAPI.DataAccessLayer.Context;
using BookAPI.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BookContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Service registrations
builder.Services.AddScoped<IBookService, BookManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IWriterService, WriterManager>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();

// Dal registrations
builder.Services.AddScoped<IBookDal, EfBookDal>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<IWriterDal, EfWriterDal>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();

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
