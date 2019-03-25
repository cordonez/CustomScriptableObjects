namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Long")]
	[Serializable]
	public class VarLong : BaseVariable<long> { }
}