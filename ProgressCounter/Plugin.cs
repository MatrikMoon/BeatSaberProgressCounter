﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IllusionPlugin;

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace ProgressCounter
{
    public class Plugin : IPlugin
    {
        public string Name => "Progress";

        public string Version => "2.0";

        public void OnApplicationQuit()
        {
            SceneManager.activeSceneChanged -= OnSceneChanged;
        }

        bool _init = false;

        public void OnApplicationStart()
        {
            if (_init) return;
            _init = true;
            SceneManager.activeSceneChanged += OnSceneChanged;
        }

        private void OnSceneChanged(Scene _, Scene scene)
        {
            if (scene.buildIndex != 5) return;
            new GameObject("Counter").AddComponent<Counter>();
            //new GameObject("ScoreCounter").AddComponent<ScoreCounter>();
        }

        public void OnFixedUpdate()
        {
        }

        public void OnLevelWasInitialized(int level)
        {
        }

        public void OnLevelWasLoaded(int level)
        {
        }

        public void OnUpdate()
        {
        }
    }
}
