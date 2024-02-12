using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GameDev.Tool_BCY;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.UIElements;
//using Codice.Client.BaseCommands;
using TMPro;
using Unity.VisualScripting;

namespace GameDev.Tool_BCY
{
    public class PoolCenter : Singleton<PoolCenter>
    {
        [Serializable]
        private class PoolItem
        {
            public string ItemName;
            public GameObject Item;
            public int InitMaxNumbe;
        }

        [SerializeField] private List<PoolItem> _poolConfig = new List<PoolItem>();//外部配置对象池
        private Dictionary<string, Queue<GameObject>> _pools = new Dictionary<string, Queue<GameObject>>();//对象池
        private GameObject _itemParent;

        protected override void Awake()
        {
            base.Awake();
            _itemParent = new GameObject("对象池物品父级");
            _itemParent.transform.SetParent(this.transform);
            InitPool();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            _poolConfig.Clear();
            _pools.Clear();
        }

        private void InitPool()
        {
            if (_poolConfig.Count == 0) return;
            if (_pools == null) return;

            foreach (var p in _poolConfig)
            {
                for (int i = 0; i < p.InitMaxNumbe; i++)
                {
                    var temp_Gameobject = Instantiate(p.Item, _itemParent.transform, true);
                    temp_Gameobject.transform.position = Vector3.zero;
                    temp_Gameobject.transform.rotation = Quaternion.identity;
                    temp_Gameobject.SetActive(false);
                    if (!_pools.ContainsKey(p.ItemName))
                    {
                        _pools.Add(p.ItemName, new Queue<GameObject>());
                        _pools[p.ItemName].Enqueue(temp_Gameobject);
                    }
                    else
                        _pools[p.ItemName].Enqueue(temp_Gameobject);
                }
            }
        }

        public void Push(string poolName)
        {
            if (_pools == null) return;
            if (_pools.ContainsKey(poolName))
            {
                var temp_Gameobject = _pools[poolName].Dequeue();
                temp_Gameobject.SetActive(true);
                if (temp_Gameobject.TryGetComponent(out IPoolItem item))
                {
                    item.Spawn();
                }
                _pools[poolName].Enqueue(temp_Gameobject);
            }
            else
                GameTools.WTF($"{poolName} 池子不存在");
        }


        public void Push(string poolName, Vector3 position)
        {
            if (_pools == null) return;
            if (_pools.ContainsKey(poolName))
            {
                var temp_Gameobject = _pools[poolName].Dequeue();
                temp_Gameobject.transform.position = position;
                temp_Gameobject.SetActive(true);
                if (temp_Gameobject.TryGetComponent(out IPoolItem item))
                {
                    item.Spawn();
                }
                _pools[poolName].Enqueue(temp_Gameobject);
            }
            else
                GameTools.WTF($"{poolName} 池子不存在");
        }



        public void Push(string poolName, Vector3 position, Quaternion rotation)
        {
            if (_pools == null) return;
            if (_pools.ContainsKey(poolName))
            {
                var temp_Gameobject = _pools[poolName].Dequeue();
                temp_Gameobject.transform.position = position;
                temp_Gameobject.transform.rotation = rotation;
                temp_Gameobject.SetActive(true);
                if (temp_Gameobject.TryGetComponent(out IPoolItem item))
                {
                    item.Spawn();
                }
                _pools[poolName].Enqueue(temp_Gameobject);
            }
            else
                GameTools.WTF($"{poolName} 池子不存在");
        }



        public void PushDamageUI(string poolName, Transform parent, string damage, Color color)
        {
            //GameTools.WTF($"{poolName} 开始1");
            if (_pools == null) return;
            //GameTools.WTF($"{poolName} 开始2");
            if (_pools.ContainsKey(poolName))
            {
                var temp_Gameobject = _pools[poolName].Dequeue();

                temp_Gameobject.transform.SetParent(parent, false); // 设置父物体
                RectTransform temp_RectTransform = temp_Gameobject.GetComponent<RectTransform>();
                temp_RectTransform.anchoredPosition = new Vector2(Random.Range(temp_Gameobject.transform.position.x - 1000, temp_Gameobject.transform.position.x + 1000),
                    Random.Range(temp_Gameobject.transform.position.y - 200, temp_Gameobject.transform.position.y + 200));
                Text text = temp_Gameobject.GetComponent<Text>();
                text.text = damage;
                text.color = color;

                Shadow shadow = temp_Gameobject.AddComponent<Shadow>();
                shadow.effectColor = Color.black;
                shadow.effectDistance = new Vector2(10f, -10f);

                temp_Gameobject.SetActive(true);

                if (temp_Gameobject.TryGetComponent(out IPoolItem item))
                {
                    item.Spawn();
                }
                _pools[poolName].Enqueue(temp_Gameobject);
                //GameTools.WTF($"{poolName} 生成伤害了");
            }
            else
                GameTools.WTF($"{poolName} 池子不存在");
        }



    }
}
