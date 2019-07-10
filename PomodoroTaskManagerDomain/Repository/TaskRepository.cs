using PomodoroTaskManagerDomain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTaskManagerDomain.Model
{
    public interface TaskRepository
    {
        void AddTask(Tasks task);
    }
}
