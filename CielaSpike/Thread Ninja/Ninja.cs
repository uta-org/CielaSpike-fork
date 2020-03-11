namespace CielaSpike
{
#if !UNITY_2020 && !UNITY_2019 && !UNITY_2018 && !UNITY_2017 && !UNITY_5

    /// <summary>
    ///     Ninja jumps between threads.
    /// </summary>
    public static class Ninja
    {
        /// <summary>
        ///     Yield return it to switch to Unity main thread.
        /// </summary>
        public static readonly object JumpToUnity;

        /// <summary>
        ///     Yield return it to switch to background thread.
        /// </summary>
        public static readonly object JumpBack;

        static Ninja()
        {
            JumpToUnity = new object();
            JumpBack = new object();
        }
    }

#endif
}