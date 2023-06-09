using AndenSemesterProjekt.EFDbContext;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IBlogService, BlogService>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddDbContext<MwDbContext>();
builder.Services.AddSingleton<DbService<Post>, DbService<Post>>();



//builder.Services.AddMvc().AddRazorPagesOptions(options => {
//    options.Conventions.AuthorizeFolder("/Item");
//}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
