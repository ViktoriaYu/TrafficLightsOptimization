using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace TrafficSimulation
{
    public class Timer : MonoBehaviour
    {
        public static int minuteCount;
        public static int secondCount;
        public static float milliCount;
        public static string milliDisplay;

        public GameObject minuteBox;
        public GameObject secondBox;
        public GameObject milliBox;


        void Update()
        {
            if (GameObject.FindGameObjectsWithTag("AutonomousVehicle") != null)
            {
                milliCount += Time.deltaTime * 10;
                milliDisplay = milliCount.ToString("F0");
                milliBox.GetComponent<TextMeshProUGUI>().text = "" + milliDisplay;

                if (milliCount > 9)
                {
                    milliCount = 0;
                    secondCount++;
                }

                if (secondCount <= 9)
                {
                    secondBox.GetComponent<TextMeshProUGUI>().text = "0" + secondCount + ".";
                }
                else
                {
                    secondBox.GetComponent<TextMeshProUGUI>().text = "" + secondCount + ".";
                }

                if (secondCount >= 60)
                {
                    secondCount = 0;
                    milliCount++;
                }

                if (minuteCount <= 9)
                {
                    minuteBox.GetComponent<TextMeshProUGUI>().text = "0" + minuteCount + ":";
                }
                else
                {
                    minuteBox.GetComponent<TextMeshProUGUI>().text = "" + minuteCount + ":";
                }
            }
        }
    }
}