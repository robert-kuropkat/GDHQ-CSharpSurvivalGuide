using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DoersOfStuff.UCSSG.Command
{
    public class UserClick : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(rayOrigin, out hitInfo))
                {
                    if (hitInfo.collider.tag == "Cube")
                    {
                        ICommand click = new ClickCommand(hitInfo.collider.gameObject, new Color(Random.value, Random.value, Random.value));
                        click.Execute();
                        CommandManager.Instance.AddCommand(click);
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                PlayBack();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Unwind");
                CommandManager.Instance.ReverseCommands();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                CommandManager.Instance.DoneRecording();
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                CommandManager.Instance.ClearCommands();
            }
        }

        public void PlayBack()
        {
            Debug.Log("Playback");
            CommandManager.Instance.PlayCommands();
        }
    }

}
