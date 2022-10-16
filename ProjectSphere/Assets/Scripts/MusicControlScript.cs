using UnityEngine.Audio;
using UnityEngine;
public class MusicControlScript : MonoBehaviour
{
    public static MusicControlScript instance;

    private void Awake( )
    {
        DontDestroyOnLoad(this.gameObject);

        if ( instance == null )
        {
            instance = this;
        }
        else
        {
            
            Destroy(gameObject);
        }

    }
}
