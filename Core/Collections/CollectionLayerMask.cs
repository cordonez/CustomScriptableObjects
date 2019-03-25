namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "LayerMask")]
	[Serializable]
	public class CollectionLayerMask : BaseCollection<LayerMask> { }
}