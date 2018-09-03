using System;
using System.Collections.Generic;
using APIPag24horas.Model.Context;
using APIPag24horas.Business;
using APIPag24horas.Business.Implementattions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using APIPag24horas.Repository.Generic;
using Microsoft.Net.Http.Headers;
using Tapioca.HATEOAS;
using APIPag24horas.Hypermedia;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Rewrite;
using APIPag24horas.Security.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using APIPag24horas.Repository.Implementattions;
using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Business.cbolso.Implementattions;
using APIPag24horas.Repository.cbolso;

namespace APIPag24horas
{
    public class Startup
    {
        private readonly ILogger _logger;
        public IConfiguration _configuration { get; }
        public IHostingEnvironment _environment { get; }


        public Startup(IConfiguration configuration, IHostingEnvironment environment, ILogger<Startup> logger)
        {
            _configuration = configuration;
            _environment = environment;
            _logger = logger;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration["MySqlConnection:MySqlConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connectionString));
            var connectionString2 = _configuration["MySqlConnection2:MySqlConnectionString2"];
            services.AddDbContext<MySQLCbolsoContext>(options => options.UseMySql(connectionString2));
            services.AddApiVersioning();

            ExecuteMigrations(connectionString);

            // ***Início do código de autenticação - Start authentication Code ***
            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();

            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                _configuration.GetSection("TokenConfigurations")
            )
            .Configure(tokenConfigurations);

            services.AddSingleton(tokenConfigurations);


            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;

                // Validates the signing of a received token
                paramsValidation.ValidateIssuerSigningKey = true;

                // Checks if a received token is still valid
                paramsValidation.ValidateLifetime = true;

                // Tolerance time for the expiration of a token (used in case
                // of time synchronization problems between different
                // computers involved in the communication process)
                paramsValidation.ClockSkew = TimeSpan.Zero;
            });

            // Enables the use of the token as a means of
            // authorizing access to this project's resources
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
                    .RequireAuthenticatedUser().Build());
            });

            // *** Fim do código de Autenticação - End Authentication Code ***

            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;
                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("text/xml"));
                options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
            })
            .AddXmlSerializerFormatters();

            var filterOptions = new HyperMediaFilterOptions();
            filterOptions.ObjectContentResponseEnricherList.Add(new PersonEnricher());
            filterOptions.ObjectContentResponseEnricherList.Add(new BookEnricher());
            services.AddSingleton(filterOptions);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "RESTful API With ASP.NET Core 2.0",
                        Version = "v1"
                    });
            });

            // Injeção de dependência
            services.AddScoped<IPersonBusiness, PersonBusinessImpl>();
            services.AddScoped<IBookBusiness, BookBusinessImpl>();
            services.AddScoped<ILoginBusiness, LoginBusinessImpl>();
            services.AddScoped<IUserRepository, UserRepositoryImpl>();
            services.AddScoped<IPersonRepository, PersonRepositoryImpl>();
            services.AddScoped<IApitesteBusiness, ApitesteBusinessImpl>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(APIPag24horas.Repository.cbolso.Generic.IRepository<>), typeof(APIPag24horas.Repository.cbolso.Generic.GenericRepository<>));
            ServicesCbolso(services);
            

        }

        private static void ServicesCbolso(IServiceCollection services)
        {
            services.AddScoped<IUsuariosBusiness, UsuariosBusinessImpl>();
            services.AddScoped<IUsuariosRepository, UsuariosRepository>();
            services.AddScoped<IFuncionariosBusiness, FuncionariosBusinessImpl>();
            services.AddScoped<IFuncionariosRepository, FuncionariosRepository>();
        }

        private void ExecuteMigrations(string connectionString)
        {
            if (_environment.IsDevelopment())
            {
                try
                {
                    var evolveConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

                    var evolve = new Evolve.Evolve("evolve.json", evolveConnection, msg => _logger.LogInformation(msg))
                    {
                        Locations = new List<string> { "db/migrations" },
                        IsEraseDisabled = true,
                    };

                    evolve.Migrate();
                }
                catch (Exception ex)
                {
                    _logger.LogCritical("Database migration failed.", ex);
                    throw;
                }

            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            

            app.UseMvc(routes => {
                routes.MapRoute(
                        name: "DefaultApi",
                        template: "{controller=Values}/{id?}"
                    );
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            app.UseRewriter(option);
        }
    }
}
