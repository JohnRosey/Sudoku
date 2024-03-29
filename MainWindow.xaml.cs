﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sudoku
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>

public partial class MainWindow : Window
	{
		Square[,] squares = new Square[9, 9];
		

		public MainWindow()
		{
		
			InitializeComponent();
			GenerateBox();

			
		}

        private void GenerateBox()
        {
			Dictionary<string, Square> squares = new Dictionary<string, Square>(81);

			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					squares.Add("tbx" + i + "_" + j, new Square(textBox: squares));
			
		}

      
		/// <summary>
		///empeche le text box de prendre des lettres
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		  private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
		{
			Regex regex = new Regex("[^0-9]+");
			e.Handled = regex.IsMatch(e.Text);
		}
	}
}