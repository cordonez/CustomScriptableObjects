namespace CustomScriptableObjects.Core.References
{
	using System;
	using Variables;

	[Serializable]
	public class RefUnityObject : BaseReference<UnityEngine.Object, VarUnityObject> { }
}