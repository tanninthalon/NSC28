using UnityEngine;
using IronPython.Hosting;
using System.IO;
using System;

public class ScriptCompatCheck : MonoBehaviour
{
    void Start()
    {
        var engine = Python.CreateEngine();
        var scope = engine.CreateScope();

        MemoryStream ms = new MemoryStream();
        engine.Runtime.IO.SetOutput(ms, System.Text.Encoding.UTF8);

        engine.Execute("print('Hello from python!')");

        string output = System.Text.Encoding.UTF8.GetString(ms.ToArray());
        Debug.Log("Python output: " + output);
    }

    void Update()
    {
        
    }
}
