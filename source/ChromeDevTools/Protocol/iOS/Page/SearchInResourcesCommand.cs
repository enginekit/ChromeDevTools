using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.SearchInResources)]
	[SupportedBy("iOS")]
	public class SearchInResourcesCommand
	{
		/// <summary>
		/// Gets or sets String to search for.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets If true, search is case sensitive.
		/// </summary>
		public bool CaseSensitive { get; set; }
		/// <summary>
		/// Gets or sets If true, treats string parameter as regex.
		/// </summary>
		public bool IsRegex { get; set; }
	}
}
