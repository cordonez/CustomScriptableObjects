namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	using System;
	using UnityEngine;

	[Serializable]
	public abstract class CustomScriptableObject<T> : BaseCustomScriptableObject
	{
		[SerializeField]
		protected T m_value;

		[SerializeField]
		protected Action<T, T> m_onValueUpdated;

		public virtual T Value
		{
			get { return m_value; }
			set
			{
				T oldValue = m_value;
				m_value = value;
				if (m_onValueUpdated != null)
				{
					m_onValueUpdated(oldValue, Value);
				}
			}
		}

		public void AddListenerOnUpdate(Action<T, T> _callback)
		{
			m_onValueUpdated += _callback;
		}

		public void RemoveListenerOnUpdate(Action<T, T> _callback)
		{
			m_onValueUpdated -= _callback;
		}

		public static implicit operator T(CustomScriptableObject<T> _value)
		{
			return _value.Value;
		}
	}
}