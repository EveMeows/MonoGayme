using Envy.Core.UI;

namespace Envy.Core.Controllers;

public class UpdatedEventArgs(IElement element)
{
	public IElement Element = element;
}
