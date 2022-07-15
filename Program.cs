using LaMiaPizzeria.Data;
using LaMiaPizzeria.Models;

var builder = WebApplication.CreateBuilder(args);

//using(PizzaContext db = new PizzaContext())
//{
//    db.Add(new Pizza("Margherita", "La pizza classica per eccellenza", "https://cdn.shopify.com/s/files/1/0586/6795/8427/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800", 6.5));
//    db.Add(new Pizza("Diavola", "La pizza piccante per eccellenza", "https://www.misya.info/wp-content/uploads/2007/08/Pizza-alla-diavola.jpg", 7.5));
//    db.Add(new Pizza("Vegetariana", "La pizza con verdure per eccellenza", "https://blog.giallozafferano.it/maniamore/wp-content/uploads/2015/06/pizza-ratatouille.jpg", 8.5));
//    db.Add(new Pizza("Frutti di mare", "La pizza di mare per eccellenza", "https://wips.plug.it/cips/buonissimo.org/cms/2012/05/pizza-ai-frutti-di-mare.jpg", 12.5));
//    db.SaveChanges();
//}


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();




var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
