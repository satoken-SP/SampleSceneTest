using UnityEngine;

public class SecondButton : MonoBehaviour
{
    public void ChangeScene()
    {
        GameController.instance.sceneChanger.ChangeScene(SceneType.MainScene);
    }
}
