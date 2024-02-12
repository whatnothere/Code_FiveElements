using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameDev.Tool_BCY
{
    public static class GameTools
    {
        #region 向量

        /// <summary>
        /// 计算目标方向
        /// </summary>
        /// <param name="target">目标</param>
        /// <param name="self">自身</param>
        /// <param name="normal">是否归一化向量</param>
        /// <returns></returns>
        public static Vector3 CalculateDirection(Transform target, Transform self, bool normal = true)
        {
            if (normal)
            {
                return (target.position - self.position).normalized;
            }

            return (target.position - self.position);
        }

        /// <summary>
        /// 计算目标方向
        /// </summary>
        /// <param name="target">目标位置</param>
        /// <param name="self">自身位置</param>
        /// <param name="normal">是否归一化向量</param>
        /// <returns></returns>
        public static Vector3 CalculateDirection(Vector3 target, Vector3 self, bool normal = true)
        {
            if (normal)
            {
                return (target - self).normalized;
            }

            return (target - self);
        }

        /// <summary>
        /// 计算目标之间的距离
        /// </summary>
        /// <param name="target">目标位置</param>
        /// <param name="self">自身位置</param>
        /// <returns></returns>
        public static float CalculateDistance(Vector3 target, Vector3 self)
        {
            return Vector3.Distance(target, self);
        }

        /// <summary>
        /// 计算两个向量的夹角度数
        /// </summary>
        /// <param name="direction1"></param>
        /// <param name="direction2"></param>
        /// <returns></returns>
        public static float CalculateAngle(Vector3 direction1, Vector3 direction2)
        {
            return Vector3.Angle(direction1, direction2);
        }

        /// <summary>
        /// 计算两个向量的增量角
        /// </summary>
        /// <param name="rFrom">即当前的向量</param>
        /// <param name="rTo">目标向量</param>
        /// <returns></returns>
        public static float CalculateDeltaAngle(Vector3 rFrom, Vector3 rTo)
        {
            //反正切求出当前向量的角度
            float current = Mathf.Atan2(rFrom.x, rFrom.z) * Mathf.Rad2Deg;
            //反正切求出目标向量的角度
            float target = Mathf.Atan2(rTo.x, rTo.z) * Mathf.Rad2Deg;
            //通过两个角度的计算得出差异(即目标角度减去当前角度得到他们的差异值)
            return Mathf.DeltaAngle(current, target);
        }

        #endregion

        #region 数学

        /// <summary>
        /// 限制一个值在0-360之间
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float ClampValue360(float f)
        {
            f %= 360f;
            if (f < 0)
                f += 360;

            return f;
        }

        /// <summary>
        /// 限制一个值在0-180之间
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float ClampValue180(float f)
        {
            f = (f + 180f) % 360f - 180f;

            if (f < -180)
                f += 360;

            return f;
        }

        /// <summary>
        /// 阻力时间(可在Lerp函数中代替增量时间的使用),相比较DragTimeP，使用这个函数趋近目标值的速度会慢一点。
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float DragTimeE(float time)
        {
            //Mathf.Exp:自然数e的次方，即自然数e乘以多少次后的结果。
            return 1 - Mathf.Exp(-time * Time.deltaTime);
        }

        /// <summary>
        /// 阻力时间(可在Lerp函数中代替增量时间的使用)相比较DragTimeE，使用这个函数趋近目标值的速度会更快。
        /// 注意:在趋近与目标值时，变化会越来越小,不会真正抵达目标值,只会接近。
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float DragTimeP(float time)
        {
            return 1 - Mathf.Pow(time, Time.deltaTime);
        }

        /// <summary>
        /// 计算角速度
        /// </summary>
        /// <param name="quaternion"></param>
        /// <returns></returns>
        public static Vector3 CalculateAngularVelocity(Quaternion quaternion)
        {
            quaternion.ToAngleAxis(out float angleInDegrees, out Vector3 rotationAxis);

            Vector3 angularDisplacement = rotationAxis * angleInDegrees * Mathf.Deg2Rad;
            Vector3 angularVelocity = angularDisplacement / Time.deltaTime;

            return angularVelocity;
        }
        #endregion

        #region Unity

        public static void WTF(object mes)
        {
            Debug.Log($"消息日志 :<color=#ff0010>   --->   {mes}   <---   </color>");
        }

        public static bool AnimationIsTag(this Animator animator, string tag, int layer = 0)
        {
            return animator.GetCurrentAnimatorStateInfo(layer).IsTag(tag);
        }

        public static bool AnimationIsName(this Animator animator, string name, int layer = 0)
        {
            return animator.GetCurrentAnimatorStateInfo(layer).IsName(name);
        }

        public static float AnimationNormalTime(this Animator animator, int layer = 0)
        {
            return animator.GetCurrentAnimatorStateInfo(layer).normalizedTime;
        }


        /// <summary>
        /// 将LayerMask层级转化为层级索引
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="layerMask"></param>
        public static int ChangeLayerToLayer(GameObject gameObject,LayerMask layerMask)
        {
            int layer = -1;
            for (int i = 0; i < 32; i++)
            {
                if (layerMask == (layerMask | (1 << i)))
                {
                    layer = i;
                    break;
                }
            }

            if (layer == -1)
            {
                Debug.LogError("无法将LayerMask转换为层级，更改为0！");
                return 0;
            }

            return layer;
            
        }




        /// <summary>
        /// 当前目标看向指定方向
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="position"></param>
        public static void Look(this Transform transform, Vector3 position)
        {
            var pos = position;
            pos.y = 0f;
            transform.rotation = Quaternion.LookRotation(pos);
        }

        /// <summary>
        /// 当前目标看向指定方向
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="position"></param>
        public static void Look(this Transform transform, Transform position)
        {
            var pos = position.position;
            pos.y = 0f;
            transform.rotation = Quaternion.LookRotation(pos);
        }

        /// <summary>
        /// 当前目标看向指定方向
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="position">目标位置</param>
        /// <param name="lerpTime"></param>
        public static void Look(this Transform transform, Vector3 position, float lerpTime = 10f)
        {
            var pos = position;
            pos.y = 0f;
            var targetRotation = Quaternion.LookRotation(pos);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, DragTimeE(lerpTime));
        }

        /// <summary>
        /// 当前目标看向指定方向
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="position">目标位置</param>
        /// <param name="lerpTime"></param>
        public static void Look(this Transform transform, Transform position, float lerpTime = 10f)
        {
            var pos = position.position;
            pos.y = 0f;
            var targetRotation = Quaternion.LookRotation(pos);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, DragTimeE(lerpTime));
        }

        #endregion
    }
}
