using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSoft1v1.Commands
{
    public abstract class CommandBase
    {
        public abstract string Name { get; }

        public abstract string Execute(string args);
    }
}
