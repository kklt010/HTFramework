﻿using UnityEditor;
using UnityEngine;

namespace HT.Framework
{
    [CustomEditor(typeof(MousePosition))]
    internal sealed class MousePositionInspector : HTFEditor<MousePosition>
    {
        protected override bool IsEnableRuntimeData => false;

        protected override void OnInspectorDefaultGUI()
        {
            base.OnInspectorDefaultGUI();

            PropertyField(nameof(MousePosition.CanControl), "Can Control");

            GUI.enabled = Target.CanControl;

            PropertyField(nameof(MousePosition.IsCanOnUGUI), "Can Control On UGUI");
            PropertyField(nameof(MousePosition.IsCanByKey), "Can Control By Key");
            
            GUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Speed", EditorStyles.boldLabel);
            GUILayout.EndHorizontal();

            GUILayout.BeginVertical(EditorGlobalTools.Styles.Box);
            PropertyField(nameof(MousePosition.XSpeed), "X");
            PropertyField(nameof(MousePosition.YSpeed), "Y");
            PropertyField(nameof(MousePosition.ZSpeed), "Z");
            GUILayout.EndVertical();

            GUI.enabled = true;
        }
    }
}