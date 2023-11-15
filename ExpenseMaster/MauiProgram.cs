using ExpenseMaster.Models;
using ExpenseMaster.Repositories;
using Microsoft.Extensions.Logging;

namespace ExpenseMaster
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            DependencyService.Register<IExpenseItemRepository, ExpensesItemRepository>();
            DependencyService.Register<IRepository<Expense>, Repository<Expense>>();
            //builder.Services.AddSingleton<IRepository<Expense>, Repository<Expense>>();
            //builder.Services.AddSingleton<IExpenseItemRepository, ExpensesItemRepository>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}