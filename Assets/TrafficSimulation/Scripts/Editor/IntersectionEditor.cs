// Traffic Simulation
// https://github.com/mchrbn/unity-traffic-simulation

using UnityEngine;
using UnityEditor;

namespace TrafficSimulation {
    [CustomEditor(typeof(Intersection))]
    public class IntersectionEditor : Editor
    {
        private Intersection intersection;

        void OnEnable(){
            intersection = target as Intersection;
        }

        public override void OnInspectorGUI(){
            intersection.intersectionType = (IntersectionType) EditorGUILayout.EnumPopup("Intersection type", intersection.intersectionType);

            /*
            EditorGUI.BeginDisabledGroup(intersection.intersectionType != IntersectionType.STOP);

            EditorGUILayout.LabelField("Stop", EditorStyles.boldLabel);
            SerializedProperty sPrioritySegments = serializedObject.FindProperty("prioritySegments");
            EditorGUILayout.PropertyField(sPrioritySegments, new GUIContent("Priority Segments"), true);
            serializedObject.ApplyModifiedProperties();

            EditorGUI.EndDisabledGroup();
            */

            //EditorGUI.BeginDisabledGroup(intersection.intersectionType != IntersectionType.FIX_TRAFFIC_LIGHT);

            EditorGUILayout.LabelField("Traffic Lights", EditorStyles.boldLabel);
            intersection.lightsDuration = EditorGUILayout.FloatField("Light Duration (in s.)", intersection.lightsDuration);
            intersection.orangeLightDuration = EditorGUILayout.FloatField("Orange Light Duration (in s.)", intersection.orangeLightDuration);
            SerializedProperty sLightsNbr1 = serializedObject.FindProperty("lightsNbr1");
            SerializedProperty sLightsNbr2 = serializedObject.FindProperty("lightsNbr2");
            EditorGUILayout.PropertyField(sLightsNbr1, new GUIContent("Lights #1 (first to be red)"), true);
            EditorGUILayout.PropertyField(sLightsNbr2, new GUIContent("Lights #2"), true);
            serializedObject.ApplyModifiedProperties();
            
            EditorGUI.EndDisabledGroup();


            EditorGUI.BeginDisabledGroup(intersection.intersectionType != IntersectionType.GREEN_WAVE_TRAFFIC_LIGHT);

            intersection.isFirst = EditorGUILayout.Toggle("Is first intersection", intersection.isFirst);
            SerializedProperty gwNextIntersections = serializedObject.FindProperty("nextIntersections");
            EditorGUILayout.PropertyField(gwNextIntersections, new GUIContent("Next Intersections"), true);
            serializedObject.ApplyModifiedProperties();

            EditorGUI.EndDisabledGroup();
        }
    }
}
