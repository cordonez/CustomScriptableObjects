namespace Cordonez.Modules.CustomScriptableObjects.Editor
{
	using Core.References;
	using UnityEditor;
	using UnityEngine;

	public class CustomScriptableReferenceDrawer : PropertyDrawer
	{
		/// <summary>
		///     Options to display in the popup to select constant or variable.
		/// </summary>
		private readonly string[] m_popupOptions = {"Use Constant", "Use Variable"};

		/// <summary> Cached style to use to draw the popup button. </summary>
		private GUIStyle m_popupStyle;

		public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
		{
			if (m_popupStyle == null)
			{
				m_popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
				m_popupStyle.imagePosition = ImagePosition.ImageOnly;
			}

			_label = EditorGUI.BeginProperty(_position, _label, _property);
			_position = EditorGUI.PrefixLabel(_position, _label);
			EditorGUI.BeginChangeCheck();

			// Get properties
			SerializedProperty useConstant = _property.FindPropertyRelative("UseConstant");
			SerializedProperty constantValue = _property.FindPropertyRelative("ConstantValue");
			SerializedProperty variable = _property.FindPropertyRelative("CustomScriptableObject");

			// Calculate rect for configuration button
			Rect buttonRect = new Rect(_position);
			buttonRect.yMin += m_popupStyle.margin.top;
			buttonRect.width = m_popupStyle.fixedWidth + m_popupStyle.margin.right;
			_position.xMin = buttonRect.xMax;

			// Store old indent level and set it to 0, the PrefixLabel takes care of it
			int indent = EditorGUI.indentLevel;
			EditorGUI.indentLevel = 0;
			int result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, m_popupOptions, m_popupStyle);
			useConstant.boolValue = result == 0;
			EditorGUI.PropertyField(_position, useConstant.boolValue ? constantValue : variable, GUIContent.none);
			if (EditorGUI.EndChangeCheck())
			{
				_property.serializedObject.ApplyModifiedProperties();
			}

			EditorGUI.indentLevel = indent;
			EditorGUI.EndProperty();
		}
	}

	[CustomPropertyDrawer(typeof(CustomScriptableReferenceInt), true)]
	public class CustomScriptableReferenceDrawerInt : CustomScriptableReferenceDrawer { }

	[CustomPropertyDrawer(typeof(CustomScriptableReferenceFloat), true)]
	public class CustomScriptableReferenceDrawerFloat : CustomScriptableReferenceDrawer { }
}