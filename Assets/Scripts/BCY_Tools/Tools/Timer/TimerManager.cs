using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace GameDev.Tool_BCY
{
    public class TimerManager : Singleton<TimerManager>
    {
        private List<GameTimer> _activeTimers = new List<GameTimer>();//����(�����е�)�ļ�ʱ��
        private Queue<GameTimer> _dormancyTimers = new Queue<GameTimer>();//���ü�ʱ��
        [SerializeField] private int _howManyTimer;//Ĭ�ϼ�ʱ������

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
        /// ���Ի�ȡһ����ʱ��
        /// </summary>
        /// <param name="time"></param>
        /// <param name="task"></param>
        public void TryGetTimer(float time, Action task)
        {
            if (_dormancyTimers.Count == 0)//�����ǰ���߼�ʱ��һ����û�У���ô�����Լ�����һ��
            {
                _dormancyTimers.Enqueue(CreatTimer());
                GameTools.WTF("����δ�ҵ����߼�ʱ�������Ǵ�����һ����ʱ��");
            }

            var timer = _dormancyTimers.Dequeue();

            if (timer.GetTimerState() != TimerWorkState.NONE) return;

            timer.CallOut(time, task);

            _activeTimers.Add(timer);
        }










    }
}
