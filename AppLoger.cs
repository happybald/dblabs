using System;

namespace Lab1
{
    class AppLoger : ILogger
    {
        public void LogError(string message)
        {            
           ArrangeOutput(() => Console.WriteLine(message));
        }

        public void LogError(string message, Exception exception, bool printStackTrace = false)
        {
            ArrangeOutput(() =>
            {
                Console.WriteLine(message);
                Console.WriteLine($"Exception message: {exception.Message}");
                if (printStackTrace)
                {
                    Console.WriteLine($"Stack trace: {exception.StackTrace}");
                }
            });      
        }

        private void ArrangeOutput(Action action)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            action();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
