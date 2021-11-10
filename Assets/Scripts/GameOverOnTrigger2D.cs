using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    int plife = 3;
    int hlife = 3;
   


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (hlife > 0)
            {
                hlife--;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                Debug.Log("Game over! - panda wins!");
                Application.Quit();

            }
        }
        
        if (this.triggeringTag == "panda")
        {
            if (plife > 0)
            {
                plife--;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                Debug.Log("Game over! - hippo wins!");
                Application.Quit();

            }
        }
            
    }


    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
      
    }

}
