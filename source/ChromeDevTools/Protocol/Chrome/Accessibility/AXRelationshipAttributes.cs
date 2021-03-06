using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Relationships between elements other than parent/child/sibling.
	/// </summary>
	public enum AXRelationshipAttributes
	{
			Activedescendant,
			Flowto,
			Controls,
			Describedby,
			Labelledby,
			Owns,
	}
}
