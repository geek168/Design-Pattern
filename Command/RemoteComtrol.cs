using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RemoteComtrol
    {
        private List<ICommand> OnCommand;
        private List<ICommand> OffCommand;
        ICommand UndoCommand;

        public RemoteComtrol(int slots)
        {
            OnCommand = new List<ICommand>();
            OffCommand = new List<ICommand>();

            NoCommand nocommand = new NoCommand();

            for (int i = 0; i < slots; i++)
            {
                OnCommand[i] = nocommand;
                OffCommand[i] = nocommand;
            }
            UndoCommand = nocommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommand[slot] = onCommand;
            OffCommand[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommand[slot].Excute();
            UndoCommand = OnCommand[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            OffCommand[slot].Excute();
            UndoCommand = OffCommand[slot];
        }

        public void UndoButtonWasPushed()
        {
            UndoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < OnCommand.Count; i++)
            {
                sb.Append("[slot " + i + "] " + OnCommand[i].GetType().Name + "   " + OffCommand[i].GetType().Name);
            }
            return sb.ToString();
        }

    }
}
