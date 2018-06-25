namespace Cordonez.Modules.CustomScriptableObjects.Core.Collections
{
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "SOArray_Scene")]
	public class SOArray_Scene : SOArray<SO_Scene>
	{
		public override void ResetToDefault()
		{
			m_runtimeValue = (SO_Scene[]) m_value.Clone();
		}
	}
}