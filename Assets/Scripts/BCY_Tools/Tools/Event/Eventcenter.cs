using GameDev.Tool_BCY;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GameDev.Tool_BCY
{
    public class EventCenter : SingletonNonMono<EventCenter>
    {
        internal interface IEventHelp
        {
            void ClearTask();
        }

        #region 不同参数的EventHelper

        private class EventHelper : IEventHelp
        {
            private Action _task;

            public EventHelper(Action task)
            {
                _task = task;
            }
            /// <summary>
            /// 添加事件的注册函数
            /// </summary>
            /// <param name="task"></param>
            public void AddTask(Action task)
            {
                _task += task;
            }
            /// <summary>
            /// 调用事件
            /// </summary>
            public void CallEvent()
            {
                _task?.Invoke();
            }
            /// <summary>
            /// 移除事件
            /// </summary>
            /// <param name="task"></param>
            public void RemoveTask(Action task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T> : IEventHelp
        {
            private Action<T> _task;

            public EventHelper(Action<T> task)
            {
                _task = task;
            }

            public void AddTask(Action<T> task)
            {
                _task += task;
            }

            public void CallEvent(T parameter)
            {
                _task?.Invoke(parameter);
            }

            public void RemoveTask(Action<T> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2> : IEventHelp
        {
            private Action<T1, T2> _task;

            public EventHelper(Action<T1, T2> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2)
            {
                _task?.Invoke(parameter, parameter2);
            }

            public void RemoveTask(Action<T1, T2> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2, T3> : IEventHelp
        {
            private Action<T1, T2, T3> _task;

            public EventHelper(Action<T1, T2, T3> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2, T3> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2, T3 parameter3)
            {
                _task?.Invoke(parameter, parameter2, parameter3);
            }

            public void RemoveTask(Action<T1, T2, T3> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2, T3, T4> : IEventHelp
        {
            private Action<T1, T2, T3, T4> _task;

            public EventHelper(Action<T1, T2, T3, T4> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2, T3, T4> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4)
            {
                _task?.Invoke(parameter, parameter2, parameter3, parameter4);
            }

            public void RemoveTask(Action<T1, T2, T3, T4> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2, T3, T4, T5> : IEventHelp
        {
            private Action<T1, T2, T3, T4, T5> _task;

            public EventHelper(Action<T1, T2, T3, T4, T5> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2, T3, T4, T5> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5)
            {
                _task?.Invoke(parameter, parameter2, parameter3, parameter4, parameter5);
            }

            public void RemoveTask(Action<T1, T2, T3, T4, T5> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2, T3, T4, T5, T6> : IEventHelp
        {
            private Action<T1, T2, T3, T4, T5, T6> _task;

            public EventHelper(Action<T1, T2, T3, T4, T5, T6> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2, T3, T4, T5, T6> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6)
            {
                _task?.Invoke(parameter, parameter2, parameter3, parameter4, parameter5, parameter6);
            }

            public void RemoveTask(Action<T1, T2, T3, T4, T5, T6> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2, T3, T4, T5, T6, T7> : IEventHelp
        {
            private Action<T1, T2, T3, T4, T5, T6, T7> _task;

            public EventHelper(Action<T1, T2, T3, T4, T5, T6, T7> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2, T3, T4, T5, T6, T7> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7)
            {
                _task?.Invoke(parameter, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7);
            }

            public void RemoveTask(Action<T1, T2, T3, T4, T5, T6, T7> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }
        private class EventHelper<T1, T2, T3, T4, T5, T6, T7, T8> : IEventHelp
        {
            private Action<T1, T2, T3, T4, T5, T6, T7, T8> _task;

            public EventHelper(Action<T1, T2, T3, T4, T5, T6, T7, T8> task)
            {
                _task = task;
            }

            public void AddTask(Action<T1, T2, T3, T4, T5, T6, T7, T8> task)
            {
                _task += task;
            }

            public void CallEvent(T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7, T8 parameter8)
            {
                _task?.Invoke(parameter, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8);
            }

            public void RemoveTask(Action<T1, T2, T3, T4, T5, T6, T7, T8> task)
            {
                _task -= task;
            }

            public void ClearTask()
            {
                _task = null;
            }
        }

        #endregion


        /// <summary>
        /// 存放事件的字典
        /// </summary>
        private Dictionary<string, IEventHelp> _events = new Dictionary<string, IEventHelp>();


        # region 添加事件监听

        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>监听
        public void AddEvent(string eventName, Action task)
        {
            if (_events.ContainsKey(eventName))//判空，有则再注册一个函数，无则添加该事件
            {
                if (_events[eventName] is EventHelper e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T>(string eventName, Action<T> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2>(string eventName, Action<T1, T2> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2, T3>(string eventName, Action<T1, T2, T3> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5, T6>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5, T6, T7>(task));
            }
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="task">委托</param>
        public void AddEvent<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7, T8> e) e.AddTask(task);//判断字典中指定key的值是否是EventHelp,如果是则强制转换为EventHelp,然后调用方法
                else
                    GameTools.WTF($"{eventName} 事件 发生意外错误,可能是未查询到该事件。");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5, T6, T7, T8>(task));
            }
        }

        #endregion


        # region 移除事件
        
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent(string eventName, Action task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($" {eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T>(string eventName, Action<T> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2>(string eventName, Action<T1, T2> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2, T3>(string eventName, Action<T1, T2, T3> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <param name="eventName"></param>
        /// <param name="task"></param>
        public void RemoveEvent<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7, T8> e) e.RemoveTask(task);
            }
            else
                GameTools.WTF($"{eventName} 事件不存在");
        }

        #endregion


        #region 呼叫事件
        
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName"></param>
        public void CallEvent(string eventName)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper e) e.CallEvent();
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数</param>
        /// <typeparam name="T">参数类型</typeparam>
        public void CallEvent<T>(string eventName, T parameter)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T> e) e.CallEvent(parameter);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数</param>
        /// <param name="parameter2">参数</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        public void CallEvent<T1, T2>(string eventName, T1 parameter, T2 parameter2)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2> e) e.CallEvent(parameter, parameter2);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        /// <typeparam name="T3">参数类型</typeparam>
        public void CallEvent<T1, T2, T3>(string eventName, T1 parameter, T2 parameter2, T3 parameter3)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3> e) e.CallEvent(parameter, parameter2, parameter3);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        /// <param name="parameter4">参数4</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        /// <typeparam name="T3">参数类型</typeparam>
        /// <typeparam name="T4">参数类型</typeparam>
        public void CallEvent<T1, T2, T3, T4>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4> e) e.CallEvent(parameter, parameter2, parameter3, parameter4);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        /// <param name="parameter4">参数4</param>
        /// <param name="parameter5">参数5</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        /// <typeparam name="T3">参数类型</typeparam>
        /// <typeparam name="T4">参数类型</typeparam>
        /// <typeparam name="T5">参数类型</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        /// <param name="parameter4">参数4</param>
        /// <param name="parameter5">参数5</param>
        /// <param name="parameter6">参数6</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        /// <typeparam name="T3">参数类型</typeparam>
        /// <typeparam name="T4">参数类型</typeparam>
        /// <typeparam name="T5">参数类型</typeparam>
        /// <typeparam name="T6">参数类型</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5, T6>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5, parameter6);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        /// <param name="parameter4">参数4</param>
        /// <param name="parameter5">参数5</param>
        /// <param name="parameter6">参数6</param>
        /// <param name="parameter7">参数7</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        /// <typeparam name="T3">参数类型</typeparam>
        /// <typeparam name="T4">参数类型</typeparam>
        /// <typeparam name="T5">参数类型</typeparam>
        /// <typeparam name="T6">参数类型</typeparam>
        /// <typeparam name="T7">参数类型</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5, T6, T7>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }
        /// <summary>
        /// 呼叫事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="parameter">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        /// <param name="parameter4">参数4</param>
        /// <param name="parameter5">参数5</param>
        /// <param name="parameter6">参数6</param>
        /// <param name="parameter7">参数7</param>
        /// <param name="parameter8">参数8</param>
        /// <typeparam name="T1">参数类型</typeparam>
        /// <typeparam name="T2">参数类型</typeparam>
        /// <typeparam name="T3">参数类型</typeparam>
        /// <typeparam name="T4">参数类型</typeparam>
        /// <typeparam name="T5">参数类型</typeparam>
        /// <typeparam name="T6">参数类型</typeparam>
        /// <typeparam name="T7">参数类型</typeparam>
        /// <typeparam name="T8">参数类型</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7, T8 parameter8)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7, T8> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8);
            }
            else
                GameTools.WTF($"{eventName} 不存在");
        }


        #endregion



        /// <summary>
        /// 清除所有添加的事件
        /// </summary>
        public void RemoveAllEvent()
        {
            _events.Clear();
        }





    }
}