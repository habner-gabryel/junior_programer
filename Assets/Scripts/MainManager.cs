using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Color TeamColor;

   private void Awake(){
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
   }

   [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }
}
