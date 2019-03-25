namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Float")]
	[Serializable]
	public class CollectionFloat : BaseCollection<float> { }
}