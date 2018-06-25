namespace Cordonez.Modules.CustomScriptableObjects.Core.Variables
{
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "SO_Layermask")]
	public class SO_Layermask : CustomScriptableObject<LayerMask>
	{
		public bool ContainsLayer(int _layer)
		{
			return Value == (Value | (1 << _layer));
		}
	}
}