using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Command
{
    public interface ICommand 
    {
        void Execute();
        void UnDo();
    }

}
