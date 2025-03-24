using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void StartGame()
   {
      SceneManager.LoadScene("RollerCandy");
   }

   public void Credit()
   {
      SceneManager.LoadScene("CreditScene.unity");
   }

   public void Back()
   {
      SceneManager.LoadScene("MainMenu.unity");
   }
 
   public void Quit()
   {
      Application.Quit();
   }
 
}
