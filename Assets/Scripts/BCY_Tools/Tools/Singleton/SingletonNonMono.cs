using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Tool_BCY
{
    public abstract class SingletonNonMono<T> where T : class,new()
    {
        private static T _singleton;
        private static object _lock = new object();
        protected SingletonNonMono() { }//确保不能被外部实例化
        public static T MainInstance
        {
            get
            {
                if (_singleton == null)
                {
                    //上锁
                    lock (_lock)
                    {
                        _singleton ??= new T();//再次判断是否为空
                    }
                }
                return _singleton;
            }
        }
    }

}