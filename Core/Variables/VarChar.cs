namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Char")]
	[Serializable]
	public class VarChar : BaseVariable<char> { }
}