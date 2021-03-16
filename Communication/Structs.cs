using System.Collections.Generic;

namespace CRCTray.Communication
{
	struct BasicCommand
    {
		public string command { get; set; }
		public BasicCommand(string command)
        {
			this.command = command;
        }
	}

	struct ConfigSetCommand
	{
		public string command { get; set; }
		public Dictionary<string, dynamic> args { get; set; }

		public ConfigSetCommand(Dictionary<string, dynamic> args)
        {
			command = "setconfig";
			this.args = args;
		}
	}

	struct ConfigUnsetCommand
	{
		public string command;
		public List<string> args { get; set; }

		public ConfigUnsetCommand(List<string> args)
        {
			command = "unsetconfig";
			this.args = args;
        }
	}
}
