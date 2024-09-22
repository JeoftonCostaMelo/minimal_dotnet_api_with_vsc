using Modelos;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddOpenApiDocument(config => {
//     config.DocumentName = "SuperheroAPI";
//     config.Title = "SuperheroAPI V1";
//     config.Version = "v1";
// });
var app = builder.Build();

// if(app.Environment.IsDevelopment()){
//     app.UseOpenApi();
//     app.UseSwaggerUi(config => {
//         config.DocumentTitle = "SuperheroAPI";
//         config.Path = "/swagger";
//         config.DocumentPath = "/swagger/{documentName}/swagger.json";
//         config.DocExpansion = "list";
//     });
// }

app.MapGet("/", () => new SuperheroModel("Batman"));

app.Run();
