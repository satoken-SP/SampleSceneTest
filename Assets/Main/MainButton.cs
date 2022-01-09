using UnityEngine;

public class MainButton : MonoBehaviour
{
    public void ChangeScene()
    {
        GameController.instance.sceneChanger.ChangeScene(SceneType.SecondScene);
    }
}
