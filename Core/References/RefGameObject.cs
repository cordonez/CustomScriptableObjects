namespace CustomScriptableObjects.Core.References
{
	using System;
	using UnityEngine;
	using Variables;

	[Serializable]
	public class RefGameObject : BaseReference<GameObject, VarGameObject> { }
}