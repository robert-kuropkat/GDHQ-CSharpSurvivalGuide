using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DoersOfStuff.UCSSG.Command
{
    public class CommandManager : MonoBehaviour
    {
        private static CommandManager _instance;
        public static CommandManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("No Command Manager found");
                return _instance;
            }
        }

        [SerializeField] private List<ICommand> commandBuffer = new List<ICommand>();

        private void Awake() { _instance = this; }

        public void AddCommand(ICommand command)
        {
            commandBuffer.Add(command);
            Debug.Log("Command Count: " + commandBuffer.Count);
        }

        public void DoneRecording()
        {
            foreach (GameObject cube in GameObject.FindGameObjectsWithTag("Cube"))
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }

        public void PlayCommands()
        {
            StartCoroutine(PlayCommandsForward());
        }

        public void ReverseCommands()
        {
            StartCoroutine(PlayCommandsBackwards());
        }

        public void ClearCommands()
        {
            commandBuffer.Clear();
            DoneRecording();
        }

        IEnumerator PlayCommandsForward()
        {
            foreach (ICommand command in commandBuffer)
            {
                yield return new WaitForSeconds(2);
                command.Execute();
            }
        }

        IEnumerator PlayCommandsBackwards()
        {
            //commandBuffer.Reverse();
            //foreach (ICommand command in commandBuffer)
            foreach (ICommand command in Enumerable.Reverse(commandBuffer))
            {
                yield return new WaitForSeconds(2);
                command.UnDo();
            }
            //commandBuffer.Reverse();
        }

    }

}
