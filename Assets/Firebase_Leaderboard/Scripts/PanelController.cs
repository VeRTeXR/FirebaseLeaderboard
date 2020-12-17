using System;
using echo17.Signaler.Core;
using UnityEngine;

namespace Firebase_Leaderboard.Scripts
{
    public class PanelController : MonoBehaviour, ISubscriber
    {
        [SerializeField] private CanvasGroup analyticPanel;
        [SerializeField] private CanvasGroup leaderboardPanel;

        private void Awake()
        {
            Signaler.Instance.Subscribe<SwitchToAnalytics>(this, ShowAnalyticPage);
            Signaler.Instance.Subscribe<ShowLeaderboard>(this, ShowLeaderboard);
        }

        private bool ShowLeaderboard(ShowLeaderboard signal)
        {
            return true;
        }

        private bool ShowAnalyticPage(SwitchToAnalytics signal)
        {
            
                return true;

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

    internal struct ShowLeaderboard
    {
    }

    internal struct SwitchToAnalytics
    {
    }
}
