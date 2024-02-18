using usov_402_pr3_part2.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ITimeOfDayService, TimeOfDayService>();

var app = builder.Build();

app.MapGet("/", (ITimeOfDayService timeOfDayService) => {
    var result = timeOfDayService.GetTimeOfDayMessage();
    return result;
});

app.Run();

