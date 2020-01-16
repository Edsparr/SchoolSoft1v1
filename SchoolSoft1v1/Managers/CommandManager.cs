using SchoolSoft1v1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSoft1v1.Managers
{
    public interface ICommandManager
    {
        public bool TryGetCommand(string input, out CommandBase command, out string @params);
    }
    public class CommandManager : ICommandManager
    {
        private ICollection<CommandBase> commands = new List<CommandBase>();

        public CommandManager()
        {
            commands = BuildCommandCollection();
        }

        public bool TryGetCommand(string input, out CommandBase command, out string @params)
        {
            command = null;
            @params = null;
            //<name> <name>
            var splitted = input.Split(' ');
            if (splitted.Length == 0)
                return false;

            string name = splitted[0];

            command = commands.FirstOrDefault(c => c.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

            @params = string.Join(' ', splitted.Skip(1));
            return command != null;
        }

        private ICollection<CommandBase> BuildCommandCollection()
        {
            var types = typeof(CommandBase).Assembly.GetTypes()
                .Where(c => !c.IsAbstract && c.IsSubclassOf(typeof(CommandBase)));

            return types.Select(c => (CommandBase)Activator.CreateInstance(c)).ToList();
        }

    }
}
