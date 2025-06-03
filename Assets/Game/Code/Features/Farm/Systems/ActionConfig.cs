using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace Features.Farm.Systems
{
    public sealed class ActionConfig : ScriptableObject
    {
        [SerializeField] private Item[] _animations;
        
        [Serializable]
        public struct Item
        {
            public string Key;
            public float Duration;
        }
        
        private Dictionary<string, float> _animationsDict;
        public float GetDuration(string id)
        {
            if (_animationsDict == null)
            {
                _animationsDict = _animations.ToDictionary(x => x.Key, x => x.Duration);
            }
            
            if (_animationsDict.TryGetValue(id, out var value))
            {
                return value;
            }
            
            return 0f;
        }
    }
}