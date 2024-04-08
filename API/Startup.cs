using Application.Activities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        //services.AddSwaggerGen();
        
        services.AddDbContext<DataContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
        
        services.AddCors(opt=>{
            opt.AddPolicy("CorsPolicy",policy=>
            {
                 policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
            });
        });
        services.AddMediatR(typeof(List.Handler).Assembly);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            //app.UseSwagger();
            /*app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });*/
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseCors("CorsPolicy");
        
        app.UseAuthorization();
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
