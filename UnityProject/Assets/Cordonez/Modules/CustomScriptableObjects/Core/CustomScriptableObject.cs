namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.Serialization;

	[Serializable]
	public abstract class CustomScriptableObject<T> : BaseCustomScriptableObject
	{
		[SerializeField]
		protected Dictionary<MonoBehaviour, T> m_instanceValues = new Dictionary<MonoBehaviour, T>();

		[FormerlySerializedAs("m_value")]
		[SerializeField]
		protected T m_value;

		[FormerlySerializedAs("m_onValueUpdated")]
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

		public virtual T this[MonoBehaviour _owner]
		{
			get
			{
				if (!m_instanceValues.ContainsKey(_owner))
				{
					m_instanceValues[_owner] = m_value;
				}

				return m_instanceValues[_owner];
			}
			set { m_instanceValues[_owner] = value; }
		}

		public virtual bool LiberateInstance(MonoBehaviour _owner)
		{
			return m_instanceValues.Remove(_owner);
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