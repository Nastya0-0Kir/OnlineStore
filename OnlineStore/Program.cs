/*Наш интернет магазин будем предоставлять список товаров. Начнем с разработки макета.
    База данных – деталь реализации, поэтому мы пока о ней думать не будем.
    
    Создайте модель товара, добавьте каталог со списком товаров.
    Заполните список товаров любыми товарами (от 3-х и более).
    
    По адресу /catalog покажите список товаров.
    
    Реализуйте возможность добавления товаров в каталог
    
    Сделайте так, чтобы при переходе на страницу
    headers ваше веб приложение показывало все HTTP заголовки текущего запроса (слайд 14-15).
    
   Добавьте эндпоинт для очистки каталога.
*/
using OnlineStore;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var catalog = new Catalog();

app.MapGet("/catalog", () =>
{
    return catalog.Products;
});

app.MapPost("/catalog", (Product product) =>
{
    catalog.Products.Add(product);
});

app.MapDelete("/catalog", () =>
{
    catalog.Products.Clear();
});

app.Run();

