using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class MyUIDemo_Test_3 : MyUIDemo_Test_2
{
    public bool Enable;
    int? a = null;
    public delegate void Func();

    public delegate int Func_2(int i);

    public int FuncTest_2(int i)
    {
        i *= 10;
        return i;
    }
    public int FuncTest_3(int i)
    {
        i *= 100;
        return i;
    }

    public void FuncTest(Func fnc)
    {
        fnc.Invoke();
    }

    public void DelegateTest(Func_2 fnc,int num)
    {
        Debug.Log(fnc(num));
    }

    protected override void OnUpdate(float dt)
    {
        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            if (Enable)
            {
                Debug.Log("Enabled");
            }
            else
            {
                Debug.Log("not Enabled yet");
            }
        }
    }


    async void Start()
    {
        FuncTest(() => { 
            Debug.Log("1");
            OpenMethod();
            Debug.Log(a ?? 5);
            
        });
        //fn.Invoke();
        //Method();
        //Method2();
        //await Method3();
        DelegateTest(FuncTest_2, 50);
        DelegateTest(FuncTest_3, 50);
    }


    async Task OpenMethod()
    {
        Debug.Log("開啟中(5sec)");
        await Task.Delay(5000);
        Enable = true;
        Debug.Log("開啟完畢");
    }

    //async Task Method()
    //{
    //    await Task.Delay(5000);
    //    Debug.Log("Method Complete");
    //}
    //async Task Method2()
    //{
    //    await Task.Delay(4000);
    //    Debug.Log("Method_2 Complete");
    //}

    //async Task Method3()
    //{
    //    await Task.Delay(2000);
    //    Debug.Log("Method_3 Complete");
    //}
}
