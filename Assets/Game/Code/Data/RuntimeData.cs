using System;
using Game.Scripts.Components;

namespace Game.Scripts.Data
{
    [Serializable]
    public class RuntimeData
    {
        public int Level;
        public GameState GameState;
        public float LevelStartedTime;

        public float deltaTime;
    }
}