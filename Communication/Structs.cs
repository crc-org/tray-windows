using System.Collections.Generic;

namespace tray_windows.Communication
{
	struct ConfigSetCommand
	{
		public string command;
		public ConfigSetCommandArg args;
	}

	struct ConfigSetCommandArg
	{
		public Dictionary<string, dynamic> properties;
	}

	struct ConfigUnsetCommand
	{
		public string command;
		public ConfigUnsetCommandArg args;
	}

	struct ConfigUnsetCommandArg
	{
		public List<string> properties;
	}

}
