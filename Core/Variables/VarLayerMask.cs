namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "LayerMask")]
	[Serializable]
	public class VarLayerMask : BaseVariable<LayerMask>
	{
		public bool ContainsLayer(int _layer)
		{
			return Value == (Value | (1 << _layer));
		}
	}
}