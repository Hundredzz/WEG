using UnityEngine;

public class Warp : MonoBehaviour
{
    private GameObject currentTeleporter;
    public AudioSource sfx;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTeleporter != null)
            {
                sfx.Play(0);
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }
            else if(currentTeleporter = null){
                Application.Quit();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}