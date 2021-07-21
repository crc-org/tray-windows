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

	struct TelemetryRecord
    {
		public string action { get; set; }
		public string source { get; set; }
    }

	struct ConfigSetCommand
	{
		public string command { get; set; }
		public ConfigSetCommandArgs args { get; set; }

		public ConfigSetCommand(Dictionary<string, dynamic> args)
        {
			command = "setconfig";
            var cargs = new ConfigSetCommandArgs
            {
                properties = args
            };
            this.args = cargs;
		}
	}

	struct ConfigSetCommandArgs
    {
		public Dictionary<string, dynamic> properties { get; set; }
    }

	struct ConfigUnsetCommand
	{
		public string command { get; set; }
		public ConfigUnsetCommandArgs args { get; set; }

		public ConfigUnsetCommand(List<string> args)
        {
			command = "unsetconfig";
			var cargs = new ConfigUnsetCommandArgs
			{
				properties = args
			};
			this.args = cargs;
        }
	}
	
	struct ConfigUnsetCommandArgs
    {
		public List<string> properties { get; set; }
    }
}
