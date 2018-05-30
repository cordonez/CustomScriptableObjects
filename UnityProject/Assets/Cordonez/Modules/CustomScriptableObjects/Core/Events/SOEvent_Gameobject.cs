using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core.Events
{
	[CreateAssetMenu(menuName = MenuPath.EVENTS + "SOEvent_Gameobject")]
	public class SOEvent_Gameobject : CustomScriptableEvent<GameObject>
	{
	}
}