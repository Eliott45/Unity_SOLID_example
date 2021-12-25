using UnityEngine;

namespace Single_Responsibility
{
    public static class Logger 
    {
        public static void PrintToConsole(object content)
        {
            Debug.Log(content);
        }
    }
}
