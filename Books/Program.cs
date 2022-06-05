using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Program
    {

        // Создали вторую точку в приложении. Компелятор будет ругаться на это.
        // Поэтому в свойствах проекта необходимо указать какая точка будет основной
        [STAThread]
        static void Main(string[] args)
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(App.ConfigureServices);
    }
}
