using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace GameDev.Tool_BCY
{
    public class TimerManager : Singleton<TimerManager>
    {
        private List<GameTimer> _activeTimers = new List<GameTimer>();//激活(工作中的)的计时器
        private Queue<GameTimer> _dormancyTimers = new Queue<GameTimer>();//闲置计时器
        [SerializeField] private int _howManyTimer;//默认计时器数量

        protected override void Awake()
        {
            base.Awake();
            InitTimerManager();
        }

        private void Update()
        {
            UpdateTimer();
        }

        private void InitTimerManager()
        {
            for (int i = 0; i < _howManyTimer; i++)
            {
                _dormancyTimers.Enqueue(CreatTimer());
            }

        }

        private GameTimer CreatTimer()
        {
            return new GameTimer();
        }

        private void UpdateTimer()
        {
            if (_activeTimers.Count == 0) return;

            for (var i = 0; i < _activeTimers.Count; i++)
            {
                if (_activeTimers[i].GetTimerState() == TimerWorkState.DONE)
                {
                    _activeTimers[i].ResetTimer();
                    _dormancyTimers.Enqueue(_activeTimers[i]);
                    _activeTimers.Remove(_activeTimers[i]);
                }
                else
                {
                    _activeTimers[i].Workering();
                }
            }

        }





        /// <summary>
        /// 尝试获取一个计时器
        /// </summary>
        /// <param name="time"></param>
        /// <param name="task"></param>
        public void TryGetTimer(float time, Action task)
        {
            if (_dormancyTimers.Count == 0)//如果当前休眠计时器一个都没有，那么我们自己创建一个
            {
                _dormancyTimers.Enqueue(CreatTimer());
                GameTools.WTF("由于未找到休眠计时器，我们创建了一个计时器");
            }

            var timer = _dormancyTimers.Dequeue();

            if (timer.GetTimerState() != TimerWorkState.NONE) return;

            timer.CallOut(time, task);

            _activeTimers.Add(timer);
        }










    }
}
