using UnityEngine;

public class AnimalDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Element")
        {  
            Destroy(this.gameObject);
        }
    }
}
