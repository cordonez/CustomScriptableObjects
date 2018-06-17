using System;
using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	[Serializable]
	public abstract class CustomScriptableObject<T> : BaseCustomScriptableObject
	{
		[SerializeField]
		private T m_value;

		private Action m_onValueUpdated;

		public virtual T Value
		{
			get { return m_value; }
			set
			{
				m_value = value;
				if (m_onValueUpdated != null)
				{
					m_onValueUpdated();
				}
			}
		}

		public void AddListenerOnUpdate(Action _callback)
		{
			m_onValueUpdated += _callback;
		}

		public void RemoveListenerOnUpdate(Action _callback)
		{
			m_onValueUpdated -= _callback;
		}

		public static implicit operator T(CustomScriptableObject<T> _value)
		{
			return _value.m_value;
		}
	}
}