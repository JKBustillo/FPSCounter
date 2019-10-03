using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class FPSCounter : MonoBehaviour {
    public int FPS { get; private set; }
    string ruta = "C:/Users/Karmine/Desktop/fps.csv";
    int sw = 0;
    int sw1 = 0;
    ArrayList FPSs = new ArrayList();

    // Update is called once per frame
    void Update() {
        var sr = File.CreateText(ruta);
        FPS = (int)(1f / Time.unscaledDeltaTime);
        FPSs.Add(FPS + "");
        foreach (var fps in FPSs)
        {
            sr.WriteLine(fps + "");
        }
        sr.Close();
    }

    

}
