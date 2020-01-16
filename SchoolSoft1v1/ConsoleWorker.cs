using SchoolSoft1v1.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SchoolSoft1v1
{
    public class ConsoleWorker
    {
        public static ConsoleWorker Instance { get; private set; }

        public ConsoleWorker()
        {
            Instance = this;
        }

        public IFileHandler FileHandler { get; } = new FileHandler();
        public ILessonMananger LessonMananger { get; } = new LessonManager();
        public ICommandManager CommandManager { get; } = new CommandManager();


        public void Start(CancellationToken cancellationToken = default)
        {
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                Console.WriteLine("Enter command");
                var input = Console.ReadLine();
                if(!CommandManager.TryGetCommand(input, out var command, out var args))
                {
                    Console.WriteLine("Coudn't find command!");
                    continue;
                }

                string result = command.Execute(args);
                Console.WriteLine(result);
            }
        }
    }
}
