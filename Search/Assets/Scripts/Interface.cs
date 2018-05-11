using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISceneController
{
    void LoadResources();
}
public interface IUserAction
{
    void Move(float x, float y);//获得键盘输入，进行移动

    void Burst(float x, float y);//进行超级快速的瞬间移动

    int GetScore();//获得当前时间

    int GetBurstCDTime();//获得Burst的冷却时间

    bool GetGameover();
    void BeginGame();
}

public interface ISSActionCallback

{
    void SSActionEvent(SSAction source, int intParam = 0, GameObject objectParam = null);
}

