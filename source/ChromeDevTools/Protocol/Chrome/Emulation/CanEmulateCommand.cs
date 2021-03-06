using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>
	[Command(ProtocolName.Emulation.CanEmulate)]
	[SupportedBy("Chrome")]
	public class CanEmulateCommand
	{
	}
}
