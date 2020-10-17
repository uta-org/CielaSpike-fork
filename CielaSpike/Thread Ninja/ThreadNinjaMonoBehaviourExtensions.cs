using System.Collections;
using UnityEngine;

namespace CielaSpike
{
    //#if !UNITY_2020 && !UNITY_2019 && !UNITY_2018 && !UNITY_2017 && !UNITY_5

    public static class ThreadNinjaMonoBehaviourExtensions
    {
        /// <summary>
        ///     Start a co-routine on a background thread.
        /// </summary>
        /// <param name="task">Gets a task object with more control on the background thread.</param>
        /// <returns></returns>
        public static Coroutine StartCoroutineAsync(
            this MonoBehaviour behaviour, IEnumerator routine,
            out Task task)
        {
            task = new Task(routine);
            return behaviour.StartCoroutine(task);
        }

        /// <summary>
        ///     Start a co-routine on a background thread.
        /// </summary>
        public static Coroutine StartCoroutineAsync(
            this MonoBehaviour behaviour, IEnumerator routine)
        {
            return StartCoroutineAsync(behaviour, routine, out var t);
        }
    }

    //#endif
}