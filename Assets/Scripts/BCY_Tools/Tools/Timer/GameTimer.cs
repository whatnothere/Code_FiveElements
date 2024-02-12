using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



namespace GameDev.Tool_BCY
{
    /// <summary>
    /// 计时器工作状态
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
        /// 唤醒一个计时器
        /// </summary>
        /// <param name="time">计时时长</param>
        /// <param name="task">任务</param>
        public void CallOut(float time, Action task)
        {
            _maxTime = time;
            _action = task;
            _stop = false;
            _state = TimerWorkState.READY;
        }

        /// <summary>
        /// 计时器工作
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
        /// 确定计时器的状态
        /// </summary>
        /// <returns></returns>
        public TimerWorkState GetTimerState() => _state;


        /// <summary>
        /// 重置计时器
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





