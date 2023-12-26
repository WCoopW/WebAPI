namespace WebAPIProj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

         


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.MapGet("shirts", () => {
                return "Reading all the shirts";
            });

            app.MapGet("/shirts/{id}", (int id) =>
            {
                return $"Readding shirt witn ID: {id}";
            });

            app.MapPost("/shirts", () =>
            {
                return "Creating a shirt.";
            });
            app.MapPut("/shirts/{id}", (int id) =>
            {
                return $"Updating shirts with {id}";
            });
            app.MapDelete("/shirts/{id}", (int id) =>
            {
                return $"Deleting shirt with {id}";
            });

        

           
            app.Run();
        }
    }
}
