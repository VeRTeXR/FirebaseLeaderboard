using UnityEngine;
using UnityEngine.UI;

namespace Firebase_Leaderboard.Scripts
{
    public class AnalyticButtonController : MonoBehaviour
    {
        private Button button; 
    
        void Start()
        {
            button = GetComponent<Button>();
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(GoToAnalyticPage);
        }

        private void GoToAnalyticPage()
        {
        }
    }
}
