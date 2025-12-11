using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17
{
    [Flags]
    public enum FileAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public struct File
    {
        public FileAccess Permissions { get; set; }

        public bool CanRead()
        {
            return (Permissions & FileAccess.Read) == FileAccess.Read;
        }

        public bool CanWrite()
        {
            return (Permissions & FileAccess.Write) == FileAccess.Write;
        }

        public bool CanExecute()
        {
            return (Permissions & FileAccess.Execute) == FileAccess.Execute;
        }
    }
}
