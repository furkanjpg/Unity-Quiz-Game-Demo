using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    string hedefSahneAdi;
  
    public void ChangeScene()
    {
        hedefSahneAdi = "Level1";
        // Belirtilen sahneye ge�i� yap
        SceneManager.LoadScene(hedefSahneAdi);
    }
}
