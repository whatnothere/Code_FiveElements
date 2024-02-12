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

        #region ��ͬ������EventHelper

        private class EventHelper : IEventHelp
        {
            private Action _task;

            public EventHelper(Action task)
            {
                _task = task;
            }
            /// <summary>
            /// ����¼���ע�ắ��
            /// </summary>
            /// <param name="task"></param>
            public void AddTask(Action task)
            {
                _task += task;
            }
            /// <summary>
            /// �����¼�
            /// </summary>
            public void CallEvent()
            {
                _task?.Invoke();
            }
            /// <summary>
            /// �Ƴ��¼�
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
        /// ����¼����ֵ�
        /// </summary>
        private Dictionary<string, IEventHelp> _events = new Dictionary<string, IEventHelp>();


        # region ����¼�����

        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>����
        public void AddEvent(string eventName, Action task)
        {
            if (_events.ContainsKey(eventName))//�пգ�������ע��һ��������������Ӹ��¼�
            {
                if (_events[eventName] is EventHelper e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T>(string eventName, Action<T> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2>(string eventName, Action<T1, T2> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2, T3>(string eventName, Action<T1, T2, T3> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5, T6>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5, T6, T7>(task));
            }
        }
        /// <summary>
        /// ����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="task">ί��</param>
        public void AddEvent<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> task)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7, T8> e) e.AddTask(task);//�ж��ֵ���ָ��key��ֵ�Ƿ���EventHelp,�������ǿ��ת��ΪEventHelp,Ȼ����÷���
                else
                    GameTools.WTF($"{eventName} �¼� �����������,������δ��ѯ�����¼���");
            }
            else
            {
                _events.Add(eventName, new EventHelper<T1, T2, T3, T4, T5, T6, T7, T8>(task));
            }
        }

        #endregion


        # region �Ƴ��¼�
        
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($" {eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }
        /// <summary>
        /// �Ƴ��¼�
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
                GameTools.WTF($"{eventName} �¼�������");
        }

        #endregion


        #region �����¼�
        
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName"></param>
        public void CallEvent(string eventName)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper e) e.CallEvent();
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����</param>
        /// <typeparam name="T">��������</typeparam>
        public void CallEvent<T>(string eventName, T parameter)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T> e) e.CallEvent(parameter);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����</param>
        /// <param name="parameter2">����</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        public void CallEvent<T1, T2>(string eventName, T1 parameter, T2 parameter2)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2> e) e.CallEvent(parameter, parameter2);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����1</param>
        /// <param name="parameter2">����2</param>
        /// <param name="parameter3">����3</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        /// <typeparam name="T3">��������</typeparam>
        public void CallEvent<T1, T2, T3>(string eventName, T1 parameter, T2 parameter2, T3 parameter3)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3> e) e.CallEvent(parameter, parameter2, parameter3);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����1</param>
        /// <param name="parameter2">����2</param>
        /// <param name="parameter3">����3</param>
        /// <param name="parameter4">����4</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        /// <typeparam name="T3">��������</typeparam>
        /// <typeparam name="T4">��������</typeparam>
        public void CallEvent<T1, T2, T3, T4>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4> e) e.CallEvent(parameter, parameter2, parameter3, parameter4);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����1</param>
        /// <param name="parameter2">����2</param>
        /// <param name="parameter3">����3</param>
        /// <param name="parameter4">����4</param>
        /// <param name="parameter5">����5</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        /// <typeparam name="T3">��������</typeparam>
        /// <typeparam name="T4">��������</typeparam>
        /// <typeparam name="T5">��������</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����1</param>
        /// <param name="parameter2">����2</param>
        /// <param name="parameter3">����3</param>
        /// <param name="parameter4">����4</param>
        /// <param name="parameter5">����5</param>
        /// <param name="parameter6">����6</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        /// <typeparam name="T3">��������</typeparam>
        /// <typeparam name="T4">��������</typeparam>
        /// <typeparam name="T5">��������</typeparam>
        /// <typeparam name="T6">��������</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5, T6>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5, parameter6);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����1</param>
        /// <param name="parameter2">����2</param>
        /// <param name="parameter3">����3</param>
        /// <param name="parameter4">����4</param>
        /// <param name="parameter5">����5</param>
        /// <param name="parameter6">����6</param>
        /// <param name="parameter7">����7</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        /// <typeparam name="T3">��������</typeparam>
        /// <typeparam name="T4">��������</typeparam>
        /// <typeparam name="T5">��������</typeparam>
        /// <typeparam name="T6">��������</typeparam>
        /// <typeparam name="T7">��������</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5, T6, T7>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="eventName">�¼�����</param>
        /// <param name="parameter">����1</param>
        /// <param name="parameter2">����2</param>
        /// <param name="parameter3">����3</param>
        /// <param name="parameter4">����4</param>
        /// <param name="parameter5">����5</param>
        /// <param name="parameter6">����6</param>
        /// <param name="parameter7">����7</param>
        /// <param name="parameter8">����8</param>
        /// <typeparam name="T1">��������</typeparam>
        /// <typeparam name="T2">��������</typeparam>
        /// <typeparam name="T3">��������</typeparam>
        /// <typeparam name="T4">��������</typeparam>
        /// <typeparam name="T5">��������</typeparam>
        /// <typeparam name="T6">��������</typeparam>
        /// <typeparam name="T7">��������</typeparam>
        /// <typeparam name="T8">��������</typeparam>
        public void CallEvent<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, T1 parameter, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7, T8 parameter8)
        {
            if (_events.ContainsKey(eventName))
            {
                if (_events[eventName] is EventHelper<T1, T2, T3, T4, T5, T6, T7, T8> e) e.CallEvent(parameter, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8);
            }
            else
                GameTools.WTF($"{eventName} ������");
        }


        #endregion



        /// <summary>
        /// ���������ӵ��¼�
        /// </summary>
        public void RemoveAllEvent()
        {
            _events.Clear();
        }





    }
}