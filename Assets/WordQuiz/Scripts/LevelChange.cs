using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    string hedefSahneAdi;
  
    public void ChangeScene()
    {
        hedefSahneAdi = "Level1";
        // Belirtilen sahneye geçiþ yap
        SceneManager.LoadScene(hedefSahneAdi);
    }
}
