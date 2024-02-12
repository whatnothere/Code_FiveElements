using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



namespace GameDev.Tool_BCY
{
    /// <summary>
    /// ��ʱ������״̬
    /// </summary>
    public enum TimerWorkState
    {
        NONE,
        READY,
        WORKERING,
        DONE
    }

    public class GameTimer
    {
        private float _startTime;
        private float _maxTime;
        private bool _stop;
        private Action _action;
        private TimerWorkState _state;

        public GameTimer()
        {
            ResetTimer();
        }

        /// <summary>
        /// ����һ����ʱ��
        /// </summary>
        /// <param name="time">��ʱʱ��</param>
        /// <param name="task">����</param>
        public void CallOut(float time, Action task)
        {
            _maxTime = time;
            _action = task;
            _stop = false;
            _state = TimerWorkState.READY;
        }

        /// <summary>
        /// ��ʱ������
        /// </summary>
        public void Workering()
        {
            if (_stop)
            {
                ResetTimer();
                return;
            }

            _startTime += Time.deltaTime;
            if (_state != TimerWorkState.WORKERING)
                _state = TimerWorkState.WORKERING;

            if (_startTime >= _maxTime)
            {
                _action?.Invoke();
                _state = TimerWorkState.DONE;
                _stop = true;
            }
        }

        /// <summary>
        /// ȷ����ʱ����״̬
        /// </summary>
        /// <returns></returns>
        public TimerWorkState GetTimerState() => _state;


        /// <summary>
        /// ���ü�ʱ��
        /// </summary>
        public void ResetTimer()
        {
            _startTime = 0f;
            _maxTime = 0f;
            _stop = true;
            _action = null;
            _state = TimerWorkState.NONE;
        }


    }
}





