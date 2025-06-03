using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.Scripts.UI
{
    public class UIService : MonoBehaviour
	{
		public EventSystem EventSystem;

		private readonly Dictionary<Type, Screen> _screens = new Dictionary<Type, Screen>();

		private void Awake()
		{
			DontDestroyOnLoad(gameObject);
			if (!EventSystem.current && EventSystem.current != EventSystem)
			{
				EventSystem.gameObject.SetActive(false);
			}
			else
			{
				EventSystem.gameObject.SetActive(true);
			}
		}

		public void AddScreen(Screen screen)
		{
			if (_screens.ContainsKey(screen.GetType()))
			{
				_screens[screen.GetType()] = screen;
				return;
			}

			_screens.Add(screen.GetType(), screen);
		}
		public void InitScreens()
		{
			var childScreen = GetComponentsInChildren<Screen>(true);

			foreach (var screen in childScreen)
			{
				screen.SetContainer(this);

				_screens.Add(screen.GetType(), screen);

				screen.Init();
			}
		}

		public T GetScreen<T>() where T : Screen
		{
			return _screens[typeof(T)] as T;
		}

		public void Show<T>() where T : Screen
		{
			var screen = _screens[typeof(T)];

			screen.Show();
		}

		public void Hide<T>() where T : Screen
		{
			var screen = _screens[typeof(T)];

			screen.Show(false);
		}

		public void HideAll()
		{
			foreach (var screen in _screens.Values)
			{
				if (screen == null) continue;
				screen.gameObject.SetActive(false);
			}
		}
	}
}