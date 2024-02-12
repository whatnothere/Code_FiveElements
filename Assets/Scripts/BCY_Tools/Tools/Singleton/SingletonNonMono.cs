using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Tool_BCY
{
    public abstract class SingletonNonMono<T> where T : class,new()
    {
        private static T _singleton;
        private static object _lock = new object();
        protected SingletonNonMono() { }//ȷ�����ܱ��ⲿʵ����
        public static T MainInstance
        {
            get
            {
                if (_singleton == null)
                {
                    //����
                    lock (_lock)
                    {
                        _singleton ??= new T();//�ٴ��ж��Ƿ�Ϊ��
                    }
                }
                return _singleton;
            }
        }
    }

}