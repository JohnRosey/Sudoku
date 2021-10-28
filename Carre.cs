using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sudoku
{
	public class Square
	{
		public TextBox TextBox { get; set; }
		public string Notes { get; set; }
		public bool Locked { get; set; }

		

        public Square(System.Collections.Generic.Dictionary<string, Square> textBox)
        {
			
		}
    }
}