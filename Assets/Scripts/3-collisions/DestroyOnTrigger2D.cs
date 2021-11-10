using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
   // [SerializeField] NumberField lives;
    int plife = 3;
    int hlife = 3;





    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if (this.triggeringTag == "hippo")
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

                }
            }
                        
        }
            
                        
        
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
