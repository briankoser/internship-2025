using DM.MovieApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();


string bearerToken = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJhMTVmMmViNTRmNDgzMGFlOWNmNmFlMjgwNDQ0ZTEwZSIsIm5iZiI6MTc0OTU5MjQ3My4yNjEsInN1YiI6IjY4NDhhOTk5NWNhOTVhZTcxNjMwMjBhYyIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.hqPEZp0sLxQMGYHS1klgnH53dBG-vYLosmW58rdsFdY";
// RegisterSettings only needs to be called one time when your application starts-up.
MovieDbFactory.RegisterSettings( bearerToken );

app.Run();
