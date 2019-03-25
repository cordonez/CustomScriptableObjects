namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "String")]
	[Serializable]
	public class VarString : BaseVariable<string> { }
}