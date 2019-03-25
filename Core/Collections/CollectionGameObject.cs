namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "GameObject")]
	[Serializable]
	public class CollectionGameObject : BaseCollection<GameObject> { }
}