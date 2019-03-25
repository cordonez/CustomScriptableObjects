namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Short")]
	[Serializable]
	public class VarShort : BaseVariable<short> { }
}