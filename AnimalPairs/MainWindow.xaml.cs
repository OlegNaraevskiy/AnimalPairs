/*===================================================================
 * Copyright (c) 2022 Oleg Naraevskiy                   Date: 10.2022
 * Version IDE: MS VS 2022
 * Designed by: Oleg Naraevskiy / noa.oleg96@gmail.com      [10.2022]
 *===================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AnimalPairs
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			SetUpGame();
		}

		private void SetUpGame()
		{
			try
			{
				List<string> animalEmoji = new List<string>()
				{
					"🐵", "🐵",
					"🐶", "🐶",
					"🐺", "🐺",
					"🐱", "🐱",
					"🦁", "🦁",
					"🐯", "🐯",
					"🦊", "🦊",
					"🦝", "🦝"
				};

				Random random = new Random();

				foreach (var textBlock in mainGrid.Children.OfType<TextBlock>())
				{
					int index = random.Next(0, animalEmoji.Count);
					string nextEmoji = animalEmoji[index];
					textBlock.Text = nextEmoji;
					animalEmoji.RemoveAt(index);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
