using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using Prism.Events;
using System.Collections.Generic;

namespace AntilopeGP.Shared.Events
{
	public class SelectedLignesChangedEvent : PubSubEvent<IEnumerable<LigneSens>>
	{
	}
}
