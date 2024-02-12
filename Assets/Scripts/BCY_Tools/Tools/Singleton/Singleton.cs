using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Tool_BCY
{
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _singleton;
        private static readonly object _lock = new object();

        public static T MainInstance
        {
            get
            {
                if (_singleton == null)
                {
                    //上锁
                    lock (_lock)
                    {
                        //先去找有没有这个类型的对象
                        _singleton = FindObjectOfType<T>() as T;
                        //没找到
                        if (_singleton == null)
                        {
                            //场景中创建一个
                            GameObject go = new GameObject(typeof(T).Name);
                            _singleton = go.AddComponent<T>();
                        }
                    }
                }
                return _singleton;
            }
        }

        protected virtual void Awake()
        {
            //再次确保实例只有一个且不为空
            if (_singleton == null)
            {
                _singleton = (T)this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);//如果已经存在就把自身删除,即场景中已经有一个了，那么不要在创建我了。
            }
        }

        protected virtual void OnDestroy()
        {
            _singleton = null;
        }

        protected virtual void OnApplicationQuit()
        {
            _singleton = null;
            //确保程序结束后，实例为空，防止在程序结束后还有对象在呼叫。
        }
    }

}