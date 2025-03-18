using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void Start()
   {
      SceneManager.LoadScene("RollerCandy");
   }

   public void Quit()
   {
      Application.Quit();
   }
  
}
