using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void Start()
   {
      SceneManager.LoadScene("RollerCandy");
   }

   public void Back()
   {
      SceneManager.LoadScene("MainMenu");
   }
   
   public void Quit()
   {
      Application.Quit();
   }
  
}
